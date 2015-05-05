-- BEGIN of ...  THIS IS THE PART THAT ONLY SYSADMIN CAN DO and DID

--create the role in msdb (ONE TIME ONLY)
---USE [msdb]
---GO
---CREATE ROLE [CanSendEmail] AUTHORIZATION [dbo]

---grant select on sysmail_account to CanSendEmail
---grant select on sysmail_profile to CanSendEmail
---grant select on sysmail_profileaccount to CanSendEmail
---grant execute on sysmail_add_principalprofile_sp to CanSendEmail
---grant execute on sysmail_add_profileaccount_sp to CanSendEmail
---grant execute on sysmail_add_account_sp to CanSendEmail
---grant execute on sysmail_add_profile_sp to CanSendEmail
---grant execute on sp_send_dbmail to CanSendEmail


-- To be executed as sysadmin

-- To be executed as sysadmin; HAVE IN MIND THAT THE DATABASE AND ACCOUNT WERE ALREADY CREATED

-- CREATE LOGIN TEAM4OIES WITH PASSWORD='TEAM4OIES#', -- DEFAULT_DATABASE=TEAM4OIES, DEFAULT_LANGUAGE=[us_english], -- CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
-- GO


-- Assign the role CanSendEmail to the newly created user
---Use MSDB 
---GO
---exec sp_adduser 'TEAM4OIES','TEAM4OIES','CanSendEmail'

-- END of ...  THIS IS THE PART THAT ONLY SYSADMIN CAN DO and DID





-- BEGIN .... THIS IS THE ONLY PART THAT YOU CAN DO

-- To be executed as the user created
-- Assign the new user to TEAM4OIES from GUI



-- Test the email by logging into the database using the new login\
---DROP TRIGGER cfdEmailTrigger
USE msdb
GO

CREATE TRIGGER cfdEmailTrigger
ON CFD 
FOR INSERT 
AS
	EXEC sp_send_dbmail @profile_name='smtps',
	@recipients='TEAM4OIESSurgeon1@gmail.com',
	@subject='Test message TEAM4OIES',
	@body='Data for your patient has been added to the database.'
END
--GO
--END .... THIS IS THE ONLY PART THAT YOU CAN DO
--This is the body of the test message.
	--Congrates Database Mail Received By you Successfully