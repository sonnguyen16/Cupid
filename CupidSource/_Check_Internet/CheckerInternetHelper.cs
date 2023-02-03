using Cupid;
using NETWORKLIST;
using System;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;


namespace Check_Internet
{
    class CheckerInternetHelper : INetworkListManagerEvents
    {
        private int m_cookie = 0;
        private IConnectionPoint m_icp;
        private INetworkListManager m_nlm;

        public CheckerInternetHelper(form_DangNhap frm)
        {
            m_nlm = new NetworkListManager();
        }
        public void ConnectivityChanged(NLM_CONNECTIVITY newConnectivity)
        {

        }
        public INetworkListManager NLM
        {
            get
            {
                return m_nlm;
            }
        }
        public void AdviseforNetworklistManager()
        {
            IConnectionPointContainer icpc = (IConnectionPointContainer)m_nlm;
            Guid tempGuid = typeof(INetworkListManagerEvents).GUID;
            icpc.FindConnectionPoint(ref tempGuid, out m_icp);
            m_icp.Advise(this, out m_cookie);
        }
        public void UnAdviseforNetworklistManager()
        {
            m_icp.Unadvise(m_cookie);
        }
    }
}
