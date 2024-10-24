using System;
using System.Data;
using System.Net.Http.Headers;
using DVLD_DataAccess;



namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode { AddNew= 1,Update = 2 }
        enMode _Mode ;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public string Username;
        public string Password;
        public bool IsActive;

        public clsUser()
        {
            UserID = -1;
            PersonID =-1;
            Username= string.Empty;
            Password= string.Empty;
            IsActive = false;
            _Mode = enMode.AddNew;
        }

        private clsUser(int userID,int personID,string userName,string password,bool isActive)
        {
            Username = userName;
            PersonID = personID;
            PersonInfo = clsPerson.Find(PersonID);
            UserID = userID;
            Password = password;
            IsActive = isActive;
            _Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID= clsUserData.AddNewUser(PersonID,Username,Password,IsActive);
            return this.UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(UserID, PersonID, Username, Password, IsActive);
        }

        public static clsUser Find(int userID)
        {
            int personID = -1;
            string userName = string.Empty;
            string password = string.Empty;
            bool isActive = false;

            if (clsUserData.GetUserByUserId(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            else
                return null;

        }

		public static clsUser FindByPersonId(int personId)
		{
			int userID = -1;
			string userName = string.Empty;
			string password = string.Empty;
			bool isActive = false;

			if (clsUserData.GetUserByPersonId(personId, ref userID, ref userName, ref password, ref isActive))
			{
				return new clsUser(personId, userID, userName, password, isActive);
			}
			else
				return null;

		}

        public static clsUser FindByUserNameAndPassword(string userName, string password)
        {
			int userID = -1;
            int personId = -1;
			bool isActive = false;
			if (clsUserData.GetUserByUsernameAndPassword(userName, password, ref userID,ref personId, ref isActive))
			{
				return new clsUser( userID, personId, userName, password, isActive);
			}
			else
				return null;
		}

		public static clsUser Find(string userName)
        {
            int personID = -1;
            int  userID = -1;
            string password = string.Empty;
            bool isActive = false;

            if (clsUserData.GetUserByUsername(userName, ref userID, ref personID, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            else
                return null;

        }

        public static DataTable GetAll()
        {
            return clsUserData.GetAllUsers();
        }
        
        public static bool Delete(int userID)
        {
            return clsUserData.DeleteUser(userID);
        }

        public static bool IsUserExist(int userID)
        {
            return clsUserData.IsUserExist(userID);
        }

        public static bool IsUserExist(string userName)
        {
            return clsUserData.IsUserExist(userName);
        }

		public static bool IsUserExistForPersonID(int personID)
		{
			return clsUserData.IsUserExistForPersonId(personID);
		}

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        _Mode = enMode.Update;
                        if (_AddNewUser())
                            return true;
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }


    }
}
