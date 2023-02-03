sp_configure 'show advanced options', 1;  -- Bật chức năng gửi mail
GO  
RECONFIGURE;  
GO  
sp_configure 'Database Mail XPs', 1;  
GO  
RECONFIGURE  
GO  

EXECUTE msdb.dbo.sysmail_add_account_sp -- Thêm tài khoản để gửi mail
@account_name = 'CupidTeamVN',
@description = N'Đội ngũ phát triển cupid',
@email_address = 'cupidteamvn@gmail.com',
@display_name = N'Thông báo từ Cupid Team',
@username='cupidteamvn@gmail.com',
@password=N'Sondaika1',
@mailserver_name = 'smtp.gmail.com',
@port = 587,
@enable_ssl = 1

-----------------------------------------------Tạo profile
 EXECUTE msdb.dbo.sysmail_add_profile_sp
@profile_name = 'CupidTeamVN',
@description = N'Đội ngũ phát triển Cupid'
-------------------------------------------------Thêm tài khoản vào profile
 EXECUTE msdb.dbo.sysmail_add_profileaccount_sp
@profile_name = 'CupidTeamVN',
@account_name = 'CupidTeamVN',
@sequence_number = 1
---------------------------------------------
 EXECUTE msdb.dbo.sysmail_add_principalprofile_sp
@profile_name = 'CupidTeam',
@principal_name = 'public',
@is_default = 1 ;

EXEC  msdb.dbo.sp_send_dbmail -- Lệnh gửi mail
	@profile_name = 'CupidTeamVN', --Tên profile tạo ở trong SQL
	@recipients =  'upxololl@gmail.com', --Danh sách các địa Email chỉ nhận
	@body =  N'Chúc mừng bạn đã trở thành idol', --Nội dung email
	@body_format = 'HTML', -- Định dạng Email
	@subject = N'Xin chào! Chúng tôi là CupidTeam. '; --Tiêu đề Email

	 SELECT *FROM msdb.dbo.sysmail_account
SELECT *FROM msdb.dbo.sysmail_configuration
SELECT *FROM msdb.dbo.sysmail_principalprofile
SELECT *FROM msdb.dbo.sysmail_profile
SELECT *FROM msdb.dbo.sysmail_profileaccount
SELECT *FROM msdb.dbo.sysmail_profileaccount

SELECT * from msdb.dbo.sysmail_sentitems