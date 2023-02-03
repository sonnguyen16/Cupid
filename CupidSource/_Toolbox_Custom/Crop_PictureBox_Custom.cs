using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Cupid
{
    [DefaultValue("Image"), DefaultEvent("SetInitialSelection"), ToolboxBitmap(typeof(PictureBox))]
    public partial class Crop_PictureBox_Custom : Panel
    {
        #region Public delegates and events

        public delegate void SetInitialSelectionDelegate(object sender, CropBoxInitialSelectionEventArgs args);
        public event SetInitialSelectionDelegate SetInitialSelection;

        #endregion Public delegates and events

        #region Public enums

        public enum CropBoxSelectionResizeMode
        {
            Disallow,
            MaintainAspectRatio,
            Unrestricted
        }

        public enum CropBoxSelectionInitialMode
        {
            FullImage,
            Square,
            Rectangle,
            Custom,
            Size3x4
        }

        public enum CropBoxStartEditingMode
        {
            OnImageLoad,
            OnImageClick,
            OnStartEditMethodCall
        }

        #endregion Public enums

        #region Private enums

        private enum MouseMoveMode
        {
            None,
            UpLeft,
            Up,
            UpRight,
            Left,
            Move,
            Right,
            DownLeft,
            Down,
            DownRight
        }

        #endregion Private enums

        #region Private members

        private Image _resizedImage = null;
        private Rectangle _imageRectangle = Rectangle.Empty;
        private Rectangle _upperLeftHandleRectangle = Rectangle.Empty;
        private Rectangle _upperRightHandleRectangle = Rectangle.Empty;
        private Rectangle _lowerLeftHandleRectangle = Rectangle.Empty;
        private Rectangle _lowerRightHandleRectangle = Rectangle.Empty;
        private Rectangle _upRectangle = Rectangle.Empty;
        private Rectangle _downRectangle = Rectangle.Empty;
        private Rectangle _leftRectangle = Rectangle.Empty;
        private Rectangle _rightRectangle = Rectangle.Empty;
        private Point _mouseDownLocation = Point.Empty;
        private MouseMoveMode _mouseMoveMode = MouseMoveMode.None;
        private bool _editing = false;
        private Rectangle _initialSelectionRectangle = Rectangle.Empty;

        #endregion Private members

        #region Public properties

        private Image _image = null;
        [Bindable(true), DefaultValue(null), Category("Appearance"), Localizable(false), Description("Gets or sets the image for the control")]
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;

                if (Array.IndexOf(_image.PropertyIdList, 274) > -1)
                {
                    var orientation = (int)_image.GetPropertyItem(274).Value[0];
                    switch (orientation)
                    {
                        case 1:
                            // No rotation required.
                            break;
                        case 2:
                            _image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            break;
                        case 3:
                            _image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 4:
                            _image.RotateFlip(RotateFlipType.Rotate180FlipX);
                            break;
                        case 5:
                            _image.RotateFlip(RotateFlipType.Rotate90FlipX);
                            break;
                        case 6:
                            _image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 7:
                            _image.RotateFlip(RotateFlipType.Rotate270FlipX);
                            break;
                        case 8:
                            _image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                    }

                    // This EXIF data is now invalid and should be removed.
                    _image.RemovePropertyItem(274);
                }

                _editing = false;

                CalculateImageRectangle();

                if (StartEditingMode == CropBoxStartEditingMode.OnImageLoad)
                {
                    StartEdit();
                }

                this.Invalidate();
            }
        }

        private Color _overlayColor = Color.Black;
        [Bindable(true), DefaultValue(typeof(Color), "Black"), Category("Appearance"), Localizable(false), Description("Gets or sets the color of the control overlay")]
        public Color OverlayColor
        {
            get
            {
                return _overlayColor;
            }
            set
            {
                if (_overlayColor != value)
                {
                    _overlayColor = value;
                    this.Invalidate();
                }
            }
        }

        private int _overlayAlpha = 100;
        [Bindable(true), DefaultValue(100), Category("Appearance"), Localizable(false), Description("Gets or sets the alpha channel value of the control overlay")]
        public int OverlayAlpha
        {
            get
            {
                return _overlayAlpha;
            }
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new ArgumentOutOfRangeException("OverlayAlpha", value, "The value must be between 0 and 255");
                }
                else if (_overlayAlpha != value)
                {
                    _overlayAlpha = value;
                    this.Invalidate();
                }
            }
        }

        [Browsable(false)]
        public Rectangle Selection
        {
            get
            {
                return ScaleRectangleUp(SelectionRectangle);
            }
            set
            {
                SelectionRectangle = ScaleRectangleDown(value);
            }
        }

        private Color _selectionBorderColor = Color.Gray;
        [Bindable(true), DefaultValue(typeof(Color), "Gray"), Category("Appearance"), Localizable(false), Description("Gets or sets the color of the selection rectangle border")]
        public Color SelectionBorderColor
        {
            get
            {
                return _selectionBorderColor;
            }
            set
            {
                if (_selectionBorderColor != value)
                {
                    _selectionBorderColor = value;
                    this.Invalidate();
                }
            }
        }

        private DashStyle _selectionBorderDashStyle = DashStyle.Dash;
        [Bindable(true), DefaultValue(typeof(DashStyle), "Dash"), Category("Appearance"), Localizable(false), Description("Gets or sets the dashstyle of the selection rectangle border")]
        public DashStyle SelectionBorderDashStyle
        {
            get
            {
                return _selectionBorderDashStyle;
            }
            set
            {
                if (_selectionBorderDashStyle != value)
                {
                    _selectionBorderDashStyle = value;
                    this.Invalidate();
                }
            }
        }

        private float[] _selectionBorderDashPattern = null;
        [Browsable(false)]
        public float[] SelectionBorderDashPattern
        {
            get
            {
                return _selectionBorderDashPattern;
            }
            set
            {
                if (_selectionBorderDashPattern != value)
                {
                    _selectionBorderDashPattern = value;
                    this.Invalidate();
                }
            }
        }

        private int _selectionBorderWidth = 2;
        [Bindable(true), DefaultValue(2), Category("Appearance"), Localizable(false), Description("Gets or sets the width of the selection rectangle border")]
        public int SelectionBorderWidth
        {
            get
            {
                return _selectionBorderWidth;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("SelectionResizeHandleBorderWidth", value, "Value must be larger than 0");
                }

                if (_selectionBorderWidth != value)
                {
                    _selectionBorderWidth = value;
                    CalculateSelectionHandleRectangles();
                    this.Invalidate();
                }
            }
        }

        private CropBoxSelectionInitialMode _selectionInitialMode = CropBoxSelectionInitialMode.FullImage;
        [Bindable(true), DefaultValue(typeof(CropBoxSelectionInitialMode), "FullImage"), Category("Behavior"), Localizable(false), Description("Gets or sets how the selection should be when the image is first loaded")]
        public CropBoxSelectionInitialMode SelectionInitialMode
        {
            get
            {
                return _selectionInitialMode;
            }
            set
            {
                if (_selectionInitialMode != value)
                {
                    _selectionInitialMode = value;
                    InitializeSelectionRectangle();
                    this.Invalidate();
                }
            }
        }

        private Color _selectionResizeHandleBorderColor = Color.Black;
        [Bindable(true), DefaultValue(typeof(Color), "Black"), Category("Appearance"), Localizable(false), Description("Gets or sets the border color of the selection resize handles")]
        public Color SelectionResizeHandleBorderColor
        {
            get
            {
                return _selectionResizeHandleBorderColor;
            }
            set
            {
                if (_selectionResizeHandleBorderColor != value)
                {
                    _selectionResizeHandleBorderColor = value;
                    this.Invalidate();
                }
            }
        }

        private int _selectionResizeHandleBorderWidth = 2;
        [Bindable(true), DefaultValue(2), Category("Appearance"), Localizable(false), Description("Gets or sets the border width of the selection resize handles")]
        public int SelectionResizeHandleBorderWidth
        {
            get
            {
                return _selectionResizeHandleBorderWidth;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("SelectionResizeHandleBorderWidth", value, "Value must be larger than 0");
                }

                if (_selectionResizeHandleBorderWidth != value)
                {
                    _selectionResizeHandleBorderWidth = value;
                    CalculateSelectionHandleRectangles();
                    this.Invalidate();
                }
            }
        }

        private Color _selectionResizeHandleColor = Color.White;
        [Bindable(true), DefaultValue(typeof(Color), "White"), Category("Appearance"), Localizable(false), Description("Gets or sets the center color of the selection resize handles")]
        public Color SelectionResizeHandleColor
        {
            get
            {
                return _selectionResizeHandleColor;
            }
            set
            {
                if (_selectionResizeHandleColor != value)
                {
                    _selectionResizeHandleColor = value;
                    this.Invalidate();
                }
            }
        }

        private CropBoxSelectionResizeMode _selectionResizeMode = CropBoxSelectionResizeMode.MaintainAspectRatio;
        [Bindable(true), DefaultValue(typeof(CropBoxSelectionResizeMode), "MaintainAspectRatio"), Category("Behavior"), Localizable(false), Description("Gets or sets how the selection can be resized")]
        public CropBoxSelectionResizeMode SelectionResizeMode
        {
            get
            {
                return _selectionResizeMode;
            }
            set
            {
                if (_selectionResizeMode != value)
                {
                    _selectionResizeMode = value;

                    if (_selectionResizeMode == CropBoxSelectionResizeMode.MaintainAspectRatio && SelectionRectangle != null)
                    {
                        _initialSelectionRectangle = new Rectangle(SelectionRectangle.Location, SelectionRectangle.Size);
                    }

                    this.Invalidate();
                }
            }
        }

        private CropBoxStartEditingMode _startEditingMode = CropBoxStartEditingMode.OnImageLoad;
        [Bindable(true), DefaultValue(typeof(CropBoxStartEditingMode), "OnImageLoad"), Category("Behavior"), Localizable(false), Description("Gets or sets how the editing mode should be activated")]
        public CropBoxStartEditingMode StartEditingMode
        {
            get
            {
                return _startEditingMode;
            }
            set
            {
                if (_startEditingMode != value)
                {
                    _startEditingMode = value;
                    this.Invalidate();
                }
            }
        }

        private int _thumbnailScalingPercentage = 10;
        [Bindable(true), DefaultValue(10), Category("Behavior"), Localizable(false), Description("Gets or sets scale for the thumbnail in percent - Between 1 and 100")]
        public int ThumbnailScalingPercentage
        {
            get
            {
                return _thumbnailScalingPercentage;
            }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("ThumbnailScalingPercentage", value, "The value must be between 1 and 100");
                }
                else if (_thumbnailScalingPercentage != value)
                {
                    _thumbnailScalingPercentage = value;
                    this.Invalidate();
                }
            }
        }

        #endregion Public properties

        #region Private properties

        private Rectangle _selectionRectangle = Rectangle.Empty;
        private Rectangle SelectionRectangle
        {
            get
            {
                return _selectionRectangle;
            }
            set
            {
                _selectionRectangle = value;
                _offsetSelectionRectangle = new Rectangle(_imageRectangle.X + _selectionRectangle.X, _imageRectangle.Y + _selectionRectangle.Y, _selectionRectangle.Width, _selectionRectangle.Height);
                CalculateSelectionHandleRectangles();
                this.Invalidate();
            }
        }

        private Rectangle _offsetSelectionRectangle = Rectangle.Empty;
        private Rectangle OffsetSelectionRectangle
        {
            get
            {
                return _offsetSelectionRectangle;
            }
            set
            {
                _offsetSelectionRectangle = value;
                _selectionRectangle = new Rectangle(_offsetSelectionRectangle.X - _imageRectangle.X, _offsetSelectionRectangle.Y - _imageRectangle.Y, _offsetSelectionRectangle.Width, _offsetSelectionRectangle.Height);
                CalculateSelectionHandleRectangles();
                this.Invalidate();
            }
        }

        #endregion Private properties

        #region Constructor

        public Crop_PictureBox_Custom()
        {
            SetStyle(ControlStyles.ResizeRedraw |
                        ControlStyles.SupportsTransparentBackColor |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.UserPaint |
                        ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.DoubleBuffer, true);
        }

        #endregion Constructor

        #region Overriden base class event

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            this.Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (!_editing && StartEditingMode == CropBoxStartEditingMode.OnImageClick)
            {
                if (_imageRectangle.Contains(e.Location))
                {
                    StartEdit();
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_editing && ((e.Button & MouseButtons.Left) == MouseButtons.Left))
            {
                _mouseDownLocation = e.Location;
                _mouseMoveMode = TranslateMouseLocation(e.Location);
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (!_editing)
                return;

            if (_mouseMoveMode == MouseMoveMode.None)
            {
                MouseMoveMode mode = TranslateMouseLocation(e.Location);
                UpdateMouseCursor(mode);
            }
            else
            {
                Rectangle currentSelection = new Rectangle(OffsetSelectionRectangle.Location, OffsetSelectionRectangle.Size);

                int deltaX = e.Location.X - _mouseDownLocation.X;
                int deltaY = e.Location.Y - _mouseDownLocation.Y;

                switch (_mouseMoveMode)
                {
                    case MouseMoveMode.Move:
                        currentSelection.X += deltaX;
                        currentSelection.Y += deltaY;
                        break;
                    case MouseMoveMode.UpLeft:
                        currentSelection.X += deltaX;
                        currentSelection.Width -= deltaX;
                        currentSelection.Y += deltaY;
                        currentSelection.Height -= deltaY;
                        break;
                    case MouseMoveMode.Up:
                        currentSelection.Y += deltaY;
                        currentSelection.Height -= deltaY;
                        break;
                    case MouseMoveMode.UpRight:
                        currentSelection.Width += deltaX;
                        currentSelection.Y += deltaY;
                        currentSelection.Height -= deltaY;
                        break;
                    case MouseMoveMode.Left:
                        currentSelection.X += deltaX;
                        currentSelection.Width -= deltaX;
                        break;
                    case MouseMoveMode.Right:
                        currentSelection.Width += deltaX;
                        break;
                    case MouseMoveMode.DownLeft:
                        currentSelection.X += deltaX;
                        currentSelection.Width -= deltaX;
                        currentSelection.Height += deltaY;
                        break;
                    case MouseMoveMode.Down:
                        currentSelection.Height += deltaY;
                        break;
                    case MouseMoveMode.DownRight:
                        currentSelection.Width += deltaX;
                        currentSelection.Height += deltaY;
                        break;
                    case MouseMoveMode.None:
                        break;
                }

                ValidateSelectionRectangle(ref currentSelection);
                OffsetSelectionRectangle = currentSelection;
                _mouseDownLocation = e.Location;
                this.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_editing)
            {
                _mouseDownLocation = Point.Empty;
                _mouseMoveMode = MouseMoveMode.None;

                if (SelectionRectangle.Width < 0 || SelectionRectangle.Height < 0 || OffsetSelectionRectangle.Width < 0 || OffsetSelectionRectangle.Height < 0)
                {
                    OffsetSelectionRectangle = FixNegativeRectangle(OffsetSelectionRectangle);
                    OffsetSelectionRectangle = FixNegativeRectangle(OffsetSelectionRectangle);
                    CalculateSelectionHandleRectangles();
                    this.Invalidate();
                }

                UpdateMouseCursor(_mouseMoveMode);
            }

            base.OnMouseUp(e);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Image != null && _imageRectangle != null)
            {
                //Draw image
                e.Graphics.CompositingMode = CompositingMode.SourceOver;
                e.Graphics.CompositingQuality = CompositingQuality.Default;
                e.Graphics.InterpolationMode = InterpolationMode.Default;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Default;

                e.Graphics.DrawImage(_resizedImage, _imageRectangle, 0, 0, _resizedImage.Width, _resizedImage.Height, GraphicsUnit.Pixel);
            }

            if (!_editing)
                return;

            //Draw overlay
            if (OverlayAlpha > 0)
            {
                using (SolidBrush overlayBrush = new SolidBrush(Color.FromArgb(OverlayAlpha, OverlayColor.R, OverlayColor.G, OverlayColor.B)))
                {
                    e.Graphics.FillRectangle(overlayBrush, e.ClipRectangle);
                }
            }

            if (Image == null || _imageRectangle == null)
                return;

            if (SelectionRectangle == null || SelectionRectangle.Equals(Rectangle.Empty))
                return;

            Rectangle selRectangle = FixNegativeRectangle(SelectionRectangle);
            Rectangle offRectangle = FixNegativeRectangle(OffsetSelectionRectangle);

            //Draw selection
            e.Graphics.DrawImage(_resizedImage, offRectangle, selRectangle.X, selRectangle.Y, selRectangle.Width, selRectangle.Height, GraphicsUnit.Pixel);

            //Draw selection border
            using (Pen borderPen = new Pen(SelectionBorderColor, SelectionBorderWidth))
            {
                borderPen.DashStyle = _selectionBorderDashStyle;

                if (borderPen.DashStyle == DashStyle.Custom)
                {
                    if (SelectionBorderDashPattern != null)
                    {
                        borderPen.DashPattern = _selectionBorderDashPattern;
                    }
                    else
                    {
                        borderPen.DashStyle = DashStyle.Dash;
                    }
                }

                e.Graphics.DrawRectangle(borderPen, offRectangle);
            }

            if (SelectionResizeMode == CropBoxSelectionResizeMode.Disallow)
                return;

            //Draw selection handles

            if (SelectionResizeMode != CropBoxSelectionResizeMode.Disallow)
            {
                using (Pen handlePen = new Pen(SelectionResizeHandleBorderColor, SelectionResizeHandleBorderWidth))
                {
                    using (Brush handleBrush = new SolidBrush(SelectionResizeHandleColor))
                    {

                        e.Graphics.FillRectangle(handleBrush, _upperLeftHandleRectangle);
                        e.Graphics.DrawRectangle(handlePen, _upperLeftHandleRectangle);

                        e.Graphics.FillRectangle(handleBrush, _upperRightHandleRectangle);
                        e.Graphics.DrawRectangle(handlePen, _upperRightHandleRectangle);

                        e.Graphics.FillRectangle(handleBrush, _lowerLeftHandleRectangle);
                        e.Graphics.DrawRectangle(handlePen, _lowerLeftHandleRectangle);

                        e.Graphics.FillRectangle(handleBrush, _lowerRightHandleRectangle);
                        e.Graphics.DrawRectangle(handlePen, _lowerRightHandleRectangle);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            CalculateImageRectangle();
            InitializeSelectionRectangle();

            this.Invalidate();
        }

        #endregion Overriden base class event

        #region Public methods

        public Image GetCroppedImage()
        {
            Rectangle selRectangle = FixNegativeRectangle(SelectionRectangle);

            Rectangle cropRectangle = ScaleRectangleUp(selRectangle);

            if (SelectionInitialMode == CropBoxSelectionInitialMode.Square && SelectionResizeMode != CropBoxSelectionResizeMode.Unrestricted)
            {
                if (cropRectangle.Width != cropRectangle.Height)
                {
                    //Fix rounding error to maintain square
                    int min = Math.Min(cropRectangle.Width, cropRectangle.Height);
                    int max = Math.Max(cropRectangle.Width, cropRectangle.Height);

                    cropRectangle.Width = max;
                    cropRectangle.Height = max;

                    Rectangle imageRectangle = new Rectangle(new Point(0, 0), Image.Size);

                    if (!imageRectangle.Contains(cropRectangle))
                    {
                        cropRectangle.Width = min;
                        cropRectangle.Height = min;
                    }
                }
            }

            Bitmap croppedImage = new Bitmap(cropRectangle.Width, cropRectangle.Height);

            croppedImage.SetResolution(Image.HorizontalResolution, Image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                Rectangle destinationRectangle = new Rectangle(0, 0, cropRectangle.Width, cropRectangle.Height);

                g.DrawImage(Image, destinationRectangle, cropRectangle, GraphicsUnit.Pixel);
            }

            return croppedImage;
        }

        public Image GetCroppedImageThumbnail()
        {
            Image img = GetCroppedImage();

            Size thumbnailSize = new Size();

            thumbnailSize.Width = Convert.ToInt32(((float)Image.Width * (float)ThumbnailScalingPercentage) / 100f);
            thumbnailSize.Height = Convert.ToInt32(((float)Image.Height * (float)ThumbnailScalingPercentage) / 100f);

            if (SelectionInitialMode == CropBoxSelectionInitialMode.Square && SelectionResizeMode != CropBoxSelectionResizeMode.Unrestricted)
            {
                if (thumbnailSize.Width != thumbnailSize.Height)
                {
                    //Fix rounding error to maintain square
                    int min = Math.Min(thumbnailSize.Width, thumbnailSize.Height);

                    thumbnailSize.Width = min;
                    thumbnailSize.Height = min;
                }
            }

            Image thumbnail = ResizeImage(img, thumbnailSize.Width, thumbnailSize.Height, true);

            return thumbnail;
        }

        public void SaveCroppedImage(string fileName)
        {
            SaveCroppedImage(fileName, ImageFormat.Jpeg);
        }

        public void SaveCroppedImage(string fileName, ImageFormat imageFormat)
        {
            Image croppedImage = GetCroppedImage();
            croppedImage.Save(fileName, imageFormat);
        }

        public void SaveCroppedImageThumbnail(string fileName)
        {
            SaveCroppedImageThumbnail(fileName, ImageFormat.Jpeg);
        }

        public void SaveCroppedImageThumbnail(string fileName, ImageFormat imageFormat)
        {
            Image croppedImageThumbnail = GetCroppedImageThumbnail();
            croppedImageThumbnail.Save(fileName, imageFormat);
        }

        public void ResetSelection()
        {
            InitializeSelectionRectangle();

            this.Invalidate();
        }

        public void StartEdit()
        {
            _editing = true;

            InitializeSelectionRectangle();

            this.Invalidate();
        }

        public void EndEdit()
        {
            _editing = false;
            this.Invalidate();
        }

        #endregion Public methods

        #region Private methods

        private void CalculateImageRectangle()
        {
            if (Image == null)
            {
                _imageRectangle = Rectangle.Empty;
            }
            else
            {
                float scaleWidth = (float)(ClientRectangle.Width - Padding.Left - Padding.Right) / (float)Image.Width;
                float scaleHeight = (float)(ClientRectangle.Height - Padding.Top - Padding.Bottom) / (float)Image.Height;

                float scale = Math.Min(scaleHeight, scaleWidth);

                _imageRectangle.Width = Convert.ToInt32(Image.Width * scale);
                _imageRectangle.Height = Convert.ToInt32(Image.Height * scale);

                _imageRectangle.X = Padding.Left + CalculateCorrectlyCenteredMargin(ClientRectangle.Width - Padding.Left - Padding.Right, _imageRectangle.Width);
                _imageRectangle.Y = Padding.Top + CalculateCorrectlyCenteredMargin(ClientRectangle.Height - Padding.Top - Padding.Bottom, _imageRectangle.Height);

                _resizedImage = ResizeImage(Image, _imageRectangle.Width, _imageRectangle.Height, true);
            }
        }

        private void InitializeSelectionRectangle()
        {
            int minSize;
            int largerSize;
            int location;

            if (Image == null)
            {
                SelectionRectangle = Rectangle.Empty;
            }
            else
            {
                Rectangle fullImageSelection = new Rectangle(0, 0, Image.Width, Image.Height);

                switch (SelectionInitialMode)
                {
                    case CropBoxSelectionInitialMode.FullImage:
                    case CropBoxSelectionInitialMode.Custom:
                        fullImageSelection = new Rectangle(0, 0, Image.Width, Image.Height);
                        break;

                    case CropBoxSelectionInitialMode.Size3x4:
                        fullImageSelection = new Rectangle(0, 0, 113, 151);
                        break;
                    case CropBoxSelectionInitialMode.Rectangle:
                        minSize = Math.Min(Image.Width, Image.Height);
                        largerSize = Convert.ToInt32((float)minSize * 4f / 3f);

                        Rectangle rectangleSelectionRectangle = new Rectangle();

                        if (Image.Width > Image.Height)
                        {
                            rectangleSelectionRectangle.Size = new Size(largerSize, minSize);

                            location = CalculateCorrectlyCenteredMargin(Image.Width, rectangleSelectionRectangle.Width);

                            rectangleSelectionRectangle.Location = new Point(location, 0);
                        }
                        else
                        {
                            rectangleSelectionRectangle.Size = new Size(minSize, largerSize);

                            location = CalculateCorrectlyCenteredMargin(Image.Height, rectangleSelectionRectangle.Height);

                            rectangleSelectionRectangle.Location = new Point(0, location);
                        }

                        fullImageSelection = rectangleSelectionRectangle;
                        break;

                    case CropBoxSelectionInitialMode.Square:
                        minSize = Math.Min(Image.Width, Image.Height);

                        Rectangle squareSelectionRectangle = new Rectangle();

                        squareSelectionRectangle.Size = new Size(minSize, minSize);

                        if (Image.Width > Image.Height)
                        {
                            location = CalculateCorrectlyCenteredMargin(Image.Width, squareSelectionRectangle.Width);

                            squareSelectionRectangle.Location = new Point(location, 0);
                        }
                        else
                        {
                            location = CalculateCorrectlyCenteredMargin(Image.Height, squareSelectionRectangle.Height);

                            squareSelectionRectangle.Location = new Point(0, location);
                        }

                        fullImageSelection = squareSelectionRectangle;
                        break;
                }

                CropBoxInitialSelectionEventArgs args = new CropBoxInitialSelectionEventArgs(Image, fullImageSelection);

                SetInitialSelection?.Invoke(this, args);

                if (args.Selection.X == 0 && args.Selection.Y == 0 && args.Selection.Height == Image.Height && args.Selection.Width == Image.Width)
                {
                    SelectionRectangle = new Rectangle(0, 0, _imageRectangle.Width, _imageRectangle.Height);
                }
                else
                {
                    SelectionRectangle = ScaleRectangleDown(args.Selection);
                }

                _initialSelectionRectangle = new Rectangle(SelectionRectangle.Location, SelectionRectangle.Size); ;
            }
        }

        private void CalculateSelectionHandleRectangles()
        {
            int handleSize = SelectionBorderWidth + (2 * SelectionResizeHandleBorderWidth);

            _upperLeftHandleRectangle = new Rectangle(OffsetSelectionRectangle.X - SelectionResizeHandleBorderWidth, OffsetSelectionRectangle.Y - SelectionResizeHandleBorderWidth, handleSize, handleSize);
            _upperRightHandleRectangle = new Rectangle(OffsetSelectionRectangle.X + OffsetSelectionRectangle.Width - SelectionResizeHandleBorderWidth, OffsetSelectionRectangle.Y - SelectionResizeHandleBorderWidth, handleSize, handleSize);
            _lowerLeftHandleRectangle = new Rectangle(OffsetSelectionRectangle.X - SelectionResizeHandleBorderWidth, OffsetSelectionRectangle.Y + OffsetSelectionRectangle.Height - SelectionResizeHandleBorderWidth - SelectionBorderWidth, handleSize, handleSize);
            _lowerRightHandleRectangle = new Rectangle(OffsetSelectionRectangle.X + OffsetSelectionRectangle.Width - SelectionResizeHandleBorderWidth, OffsetSelectionRectangle.Y + OffsetSelectionRectangle.Height - SelectionResizeHandleBorderWidth - SelectionBorderWidth, handleSize, handleSize);

            _upRectangle = new Rectangle(OffsetSelectionRectangle.X, OffsetSelectionRectangle.Y - 1, OffsetSelectionRectangle.Width, SelectionBorderWidth + 2);
            _downRectangle = new Rectangle(OffsetSelectionRectangle.X, OffsetSelectionRectangle.Y + OffsetSelectionRectangle.Height - 1, OffsetSelectionRectangle.Width, SelectionBorderWidth + 2);
            _leftRectangle = new Rectangle(OffsetSelectionRectangle.X - 1, OffsetSelectionRectangle.Y, SelectionBorderWidth + 2, OffsetSelectionRectangle.Height);
            _rightRectangle = new Rectangle(OffsetSelectionRectangle.X + OffsetSelectionRectangle.Width - 1, OffsetSelectionRectangle.Y, SelectionBorderWidth + 2, OffsetSelectionRectangle.Height);
        }

        private static int CalculateCorrectlyCenteredMargin(int x1, int x2)
        {
            return Convert.ToInt32((Convert.ToDecimal(x1) - Convert.ToDecimal(x2)) / Convert.ToDecimal(2));
        }

        private Rectangle FixNegativeRectangle(Rectangle rectangle)
        {
            if (rectangle.Width > 0 && rectangle.Height > 0)
                return rectangle;

            Rectangle fixedRectangle = new Rectangle();

            fixedRectangle.Width = Math.Abs(rectangle.Width);
            fixedRectangle.Height = Math.Abs(rectangle.Height);
            fixedRectangle.X = rectangle.Width >= 0 ? rectangle.X : rectangle.X + rectangle.Width;
            fixedRectangle.Y = rectangle.Height >= 0 ? rectangle.Y : rectangle.Y + rectangle.Height;

            return fixedRectangle;
        }

        private static Image ResizeImage(Image originalImage, int width, int height, bool keepAspect)
        {
            Size newSize = new Size(width, height);

            if (keepAspect)
            {
                // Figure out the ratio
                double ratioX = (double)width / (double)originalImage.Width;
                double ratioY = (double)height / (double)originalImage.Height;

                // use whichever multiplier is smaller
                double ratio = ratioX < ratioY ? ratioX : ratioY;

                // now we can get the new height and width
                int newHeight = Convert.ToInt32(originalImage.Height * ratio);
                int newWidth = Convert.ToInt32(originalImage.Width * ratio);

                newSize = new Size(newWidth, newHeight);
            }

            Bitmap targetImage = new Bitmap(newSize.Width, newSize.Height);

            targetImage.SetResolution(originalImage.HorizontalResolution, originalImage.VerticalResolution);

            using (Graphics g = Graphics.FromImage(targetImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                g.DrawImage(originalImage, new Rectangle(0, 0, newSize.Width, newSize.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel);
            }

            return targetImage;
        }

        private MouseMoveMode TranslateMouseLocation(Point mouseLocation)
        {
            MouseMoveMode mode = MouseMoveMode.None;

            if (OffsetSelectionRectangle.Contains(mouseLocation))
            {
                mode = MouseMoveMode.Move;
            }

            if (SelectionResizeMode != CropBoxSelectionResizeMode.Disallow)
            {
                if (_upperLeftHandleRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.UpLeft;
                }
                else if (_upperRightHandleRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.UpRight;
                }
                else if (_lowerLeftHandleRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.DownLeft;
                }
                else if (_lowerRightHandleRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.DownRight;
                }
                else if (SelectionResizeMode == CropBoxSelectionResizeMode.Unrestricted && _upRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.Up;
                }
                else if (SelectionResizeMode == CropBoxSelectionResizeMode.Unrestricted && _downRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.Down;
                }
                else if (SelectionResizeMode == CropBoxSelectionResizeMode.Unrestricted && _leftRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.Left;
                }
                else if (SelectionResizeMode == CropBoxSelectionResizeMode.Unrestricted && _rightRectangle.Contains(mouseLocation))
                {
                    mode = MouseMoveMode.Right;
                }
            }

            return mode;
        }

        private void UpdateMouseCursor(MouseMoveMode mouseMoveMode)
        {
            switch (mouseMoveMode)
            {
                case MouseMoveMode.None:
                    Cursor = Cursors.Default;
                    break;
                case MouseMoveMode.Move:
                    Cursor = Cursors.Hand;
                    break;
                case MouseMoveMode.UpLeft:
                case MouseMoveMode.DownRight:
                    Cursor = Cursors.SizeNWSE;
                    break;
                case MouseMoveMode.UpRight:
                case MouseMoveMode.DownLeft:
                    Cursor = Cursors.SizeNESW;
                    break;
                case MouseMoveMode.Up:
                case MouseMoveMode.Down:
                    Cursor = Cursors.SizeNS;
                    break;
                case MouseMoveMode.Left:
                case MouseMoveMode.Right:
                    Cursor = Cursors.SizeWE;
                    break;
            }
        }

        private void ValidateSelectionRectangle(ref Rectangle offsetSelection)
        {
            if (_mouseMoveMode == MouseMoveMode.None)
                return;

            if (_mouseMoveMode == MouseMoveMode.Move)
            {
                if (offsetSelection.X < _imageRectangle.X)
                {
                    offsetSelection.X = _imageRectangle.X;
                }

                if (offsetSelection.X > _imageRectangle.X + _imageRectangle.Width)
                {
                    offsetSelection.X = _imageRectangle.X + _imageRectangle.Width;
                }

                if (offsetSelection.Y < _imageRectangle.Y)
                {
                    offsetSelection.Y = _imageRectangle.Y;
                }

                if (offsetSelection.Y > _imageRectangle.Y + _imageRectangle.Height)
                {
                    offsetSelection.Y = _imageRectangle.Y + _imageRectangle.Height;
                }

                if (offsetSelection.Height > _imageRectangle.Height)
                {
                    offsetSelection.Height = _imageRectangle.Height;
                }

                if (offsetSelection.Width > _imageRectangle.Width)
                {
                    offsetSelection.Width = _imageRectangle.Width;
                }

                if ((offsetSelection.X + offsetSelection.Width) > (_imageRectangle.X + _imageRectangle.Width))
                {
                    offsetSelection.X = _imageRectangle.X + _imageRectangle.Width - offsetSelection.Width;
                }

                if ((offsetSelection.Y + offsetSelection.Height) > (_imageRectangle.Y + _imageRectangle.Height))
                {
                    offsetSelection.Y = _imageRectangle.Y + _imageRectangle.Height - offsetSelection.Height;
                }
            }
            else if (_mouseMoveMode == MouseMoveMode.UpLeft ||
                     _mouseMoveMode == MouseMoveMode.Up ||
                     _mouseMoveMode == MouseMoveMode.UpRight ||
                     _mouseMoveMode == MouseMoveMode.Left ||
                     _mouseMoveMode == MouseMoveMode.DownLeft)
            {
                if (SelectionResizeMode == CropBoxSelectionResizeMode.MaintainAspectRatio && _initialSelectionRectangle != null)
                {
                    //Enforce aspect ratio
                    if (offsetSelection.Width > offsetSelection.Height)
                    {
                        int widthBefore = offsetSelection.Width;
                        offsetSelection.Width = Convert.ToInt32(Convert.ToDecimal(offsetSelection.Height) * Convert.ToDecimal(_initialSelectionRectangle.Width) / Convert.ToDecimal(_initialSelectionRectangle.Height));
                        int diffX = widthBefore - offsetSelection.Width;

                        if (diffX != 0 && _mouseMoveMode != MouseMoveMode.UpRight)
                        {
                            offsetSelection.X = offsetSelection.X + diffX;
                        }
                    }
                    else
                    {
                        int heightBefore = offsetSelection.Height;
                        offsetSelection.Height = Convert.ToInt32(Convert.ToDecimal(offsetSelection.Width) * Convert.ToDecimal(_initialSelectionRectangle.Height) / Convert.ToDecimal(_initialSelectionRectangle.Width));
                        int diffY = heightBefore - offsetSelection.Height;

                        if (diffY != 0 && _mouseMoveMode != MouseMoveMode.DownLeft)
                        {
                            offsetSelection.Y = offsetSelection.Y + diffY;
                        }
                    }
                }

                if (offsetSelection.X < _imageRectangle.X)
                {
                    int diff = _imageRectangle.X - offsetSelection.X;
                    offsetSelection.X = _imageRectangle.X;
                    offsetSelection.Width -= diff;
                }

                if (offsetSelection.X > _imageRectangle.X + _imageRectangle.Width)
                {
                    int diff = _imageRectangle.X + _imageRectangle.Width - offsetSelection.X;
                    offsetSelection.X = _imageRectangle.X + _imageRectangle.Width;
                    offsetSelection.Width -= diff;
                }

                if (offsetSelection.Y < _imageRectangle.Y)
                {
                    int diff = _imageRectangle.Y - offsetSelection.Y;
                    offsetSelection.Y = _imageRectangle.Y;
                    offsetSelection.Height -= diff;
                }

                if (offsetSelection.Y > _imageRectangle.Y + _imageRectangle.Height)
                {
                    int diff = _imageRectangle.Y + _imageRectangle.Height - offsetSelection.Y;
                    offsetSelection.Y = _imageRectangle.Y + _imageRectangle.Height;
                    offsetSelection.Height -= diff;
                }

                if (offsetSelection.Height > _imageRectangle.Height)
                {
                    offsetSelection.Height = _imageRectangle.Height;
                }

                if (offsetSelection.Width > _imageRectangle.Width)
                {
                    offsetSelection.Width = _imageRectangle.Width;
                }

                if ((offsetSelection.X + offsetSelection.Width) < _imageRectangle.X)
                {
                    offsetSelection.Width = _imageRectangle.X - offsetSelection.X;
                }

                if ((offsetSelection.Y + offsetSelection.Height) < _imageRectangle.Y)
                {
                    offsetSelection.Height = _imageRectangle.Y - offsetSelection.Y;
                }

                if ((offsetSelection.X + offsetSelection.Width) > (_imageRectangle.X + _imageRectangle.Width))
                {
                    offsetSelection.Width = _imageRectangle.X + _imageRectangle.Width - offsetSelection.X;
                }

                if ((offsetSelection.Y + offsetSelection.Height) > (_imageRectangle.Y + _imageRectangle.Height))
                {
                    offsetSelection.Height = _imageRectangle.Y + _imageRectangle.Height - offsetSelection.Y;
                }
            }
            else if (_mouseMoveMode == MouseMoveMode.Right ||
                     _mouseMoveMode == MouseMoveMode.Down ||
                     _mouseMoveMode == MouseMoveMode.DownRight)
            {
                if (SelectionResizeMode == CropBoxSelectionResizeMode.MaintainAspectRatio && _initialSelectionRectangle != null)
                {
                    //Enforce aspect ratio
                    if (offsetSelection.Width > offsetSelection.Height)
                    {
                        offsetSelection.Width = Convert.ToInt32(Convert.ToDecimal(offsetSelection.Height) * Convert.ToDecimal(_initialSelectionRectangle.Width) / Convert.ToDecimal(_initialSelectionRectangle.Height));
                    }
                    else
                    {
                        offsetSelection.Height = Convert.ToInt32(Convert.ToDecimal(offsetSelection.Width) * Convert.ToDecimal(_initialSelectionRectangle.Height) / Convert.ToDecimal(_initialSelectionRectangle.Width));
                    }
                }

                if (offsetSelection.X < _imageRectangle.X)
                {
                    offsetSelection.X = _imageRectangle.X;
                }

                if (offsetSelection.X > _imageRectangle.X + _imageRectangle.Width)
                {
                    offsetSelection.X = _imageRectangle.X + _imageRectangle.Width;
                }

                if (offsetSelection.Y < _imageRectangle.Y)
                {
                    offsetSelection.Y = _imageRectangle.Y;
                }

                if (offsetSelection.Y > _imageRectangle.Y + _imageRectangle.Height)
                {
                    offsetSelection.Y = _imageRectangle.Y + _imageRectangle.Height;
                }

                if (offsetSelection.Height > _imageRectangle.Height)
                {
                    offsetSelection.Height = _imageRectangle.Height;
                }

                if (offsetSelection.Width > _imageRectangle.Width)
                {
                    offsetSelection.Width = _imageRectangle.Width;
                }

                if ((offsetSelection.X + offsetSelection.Width) < _imageRectangle.X)
                {
                    offsetSelection.Width = _imageRectangle.X - offsetSelection.X;
                }

                if ((offsetSelection.Y + offsetSelection.Height) < _imageRectangle.Y)
                {
                    offsetSelection.Height = _imageRectangle.Y - offsetSelection.Y;
                }

                if ((offsetSelection.X + offsetSelection.Width) > (_imageRectangle.X + _imageRectangle.Width))
                {
                    offsetSelection.Width = _imageRectangle.X + _imageRectangle.Width - offsetSelection.X;
                }

                if ((offsetSelection.Y + offsetSelection.Height) > (_imageRectangle.Y + _imageRectangle.Height))
                {
                    offsetSelection.Height = _imageRectangle.Y + _imageRectangle.Height - offsetSelection.Y;
                }
            }
        }

        private Rectangle ScaleRectangleUp(Rectangle rect)
        {
            if (Image == null || _resizedImage == null)
                return Rectangle.Empty;

            Rectangle scaledRectangle = new Rectangle();

            float scaleHeight = (float)Image.Height / (float)_resizedImage.Height;
            float scaleWidth = (float)Image.Width / (float)_resizedImage.Width;

            scaledRectangle.Width = Convert.ToInt32(rect.Width * scaleWidth);
            scaledRectangle.Height = Convert.ToInt32(rect.Height * scaleHeight);
            scaledRectangle.X = Convert.ToInt32(rect.X * scaleWidth);
            scaledRectangle.Y = Convert.ToInt32(rect.Y * scaleHeight);

            return scaledRectangle;
        }

        private Rectangle ScaleRectangleDown(Rectangle rect)
        {
            if (Image == null || _resizedImage == null)
                return Rectangle.Empty;

            Rectangle scaledRectangle = new Rectangle();

            float scaleHeight = (float)_resizedImage.Height / (float)Image.Height;
            float scaleWidth = (float)_resizedImage.Width / (float)Image.Width;

            scaledRectangle.Width = Convert.ToInt32(rect.Width * scaleWidth);
            scaledRectangle.Height = Convert.ToInt32(rect.Height * scaleHeight);
            scaledRectangle.X = Convert.ToInt32(rect.X * scaleWidth);
            scaledRectangle.Y = Convert.ToInt32(rect.Y * scaleHeight);

            return scaledRectangle;
        }

        #endregion Private methods
    }

    #region EventArgs class

    public class CropBoxInitialSelectionEventArgs : EventArgs
    {
        public Image Image { get; private set; }
        public Rectangle Selection { get; set; }

        public CropBoxInitialSelectionEventArgs(Image image, Rectangle selection)
        {
            Image = image;
            Selection = selection;
        }
    }

    #endregion EventArgs class
}
