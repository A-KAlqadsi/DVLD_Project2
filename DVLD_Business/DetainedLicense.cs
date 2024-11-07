﻿using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DVLD_Business
{
	public class DetainedLicense
	{
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;


		public int DetainID { set; get; }
		public int LicenseID { set; get; }
		public DateTime DetainDate { set; get; }

		public float FineFees { set; get; }
		public int CreatedByUserID { set; get; }
		public clsUser CreatedByUserInfo { set; get; }
		public bool IsReleased { set; get; }
		public DateTime? ReleaseDate { set; get; }
		public int? ReleasedByUserID { set; get; }
		public clsUser ReleasedByUserInfo { set; get; }
		public int? ReleaseApplicationID { set; get; }

		public DetainedLicense()
		{
			this.DetainID = -1;
			this.LicenseID = -1;
			this.DetainDate = DateTime.Now;
			this.FineFees = 0;
			this.CreatedByUserID = -1;
			this.IsReleased = false;
			this.ReleaseDate = null;
			this.ReleasedByUserID = null;
			this.ReleaseApplicationID = null;

			Mode = enMode.AddNew;

		}

		private DetainedLicense(int DetainID,
		   int LicenseID, DateTime DetainDate,
		   float FineFees, int CreatedByUserID,
		   bool IsReleased, DateTime? ReleaseDate,
		   int? ReleasedByUserID, int? ReleaseApplicationID)

		{
			this.DetainID = DetainID;
			this.LicenseID = LicenseID;
			this.DetainDate = DetainDate;
			this.FineFees = FineFees;
			this.CreatedByUserID = CreatedByUserID;
			this.CreatedByUserInfo = clsUser.Find(this.CreatedByUserID);
			this.IsReleased = IsReleased;
			this.ReleaseDate = ReleaseDate;
			this.ReleasedByUserID = ReleasedByUserID;
			this.ReleaseApplicationID = ReleaseApplicationID;
			if(this.ReleasedByUserID != null)
				this.ReleasedByUserInfo = clsUser.FindByPersonId(this.ReleasedByUserID?? -1);

			Mode = enMode.Update;
		}

		private bool _AddNewDetainedLicense()
		{
			//call DataAccess Layer 

			this.DetainID = clsDetainLicense.AddNewDetainedLicense(
				this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

			return (this.DetainID != -1);
		}

		private bool _UpdateDetainedLicense()
		{
			//call DataAccess Layer 

			return clsDetainLicense.UpdateDetainedLicense(
				this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
		}

		public static DetainedLicense Find(int DetainID)
		{
			int LicenseID = -1; DateTime DetainDate = DateTime.Now;
			float FineFees = 0; int CreatedByUserID = -1;
			bool IsReleased = false; DateTime? ReleaseDate = null;
			int? ReleasedByUserID = null; int? ReleaseApplicationID = null;

			if (clsDetainLicense.GetDetainedLicenseInfoByID(DetainID,
			ref LicenseID, ref DetainDate,
			ref FineFees, ref CreatedByUserID,
			ref IsReleased, ref ReleaseDate,
			ref ReleasedByUserID, ref ReleaseApplicationID))

				return new DetainedLicense(DetainID,
					 LicenseID, DetainDate,
					 FineFees, CreatedByUserID,
					 IsReleased, ReleaseDate,
					 ReleasedByUserID, ReleaseApplicationID);
			else
				return null;

		}

		public static DataTable GetAllDetainedLicenses()
		{
			return clsDetainLicense.GetAllDetainedLicenses();

		}

		public static DetainedLicense FindByLicenseID(int LicenseID)
		{
			int DetainID = -1; DateTime DetainDate = DateTime.Now;
			float FineFees = 0; int CreatedByUserID = -1;
			bool IsReleased = false; DateTime? ReleaseDate = null;
			int? ReleasedByUserID = null; int? ReleaseApplicationID =null;

			if (clsDetainLicense.GetDetainedLicenseInfoByLicenseID(LicenseID,
			ref DetainID, ref DetainDate,
			ref FineFees, ref CreatedByUserID,
			ref IsReleased, ref ReleaseDate,
			ref ReleasedByUserID, ref ReleaseApplicationID))

				return new DetainedLicense(DetainID,
					 LicenseID, DetainDate,
					 FineFees, CreatedByUserID,
					 IsReleased, ReleaseDate,
					 ReleasedByUserID, ReleaseApplicationID);
			else
				return null;

		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewDetainedLicense())
					{

						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:

					return _UpdateDetainedLicense();

			}

			return false;
		}

		public static bool IsLicenseDetained(int LicenseID)
		{
			return clsDetainLicense.IsLicenseDetained(LicenseID);
		}

		public bool ReleaseDetainedLicense(int ReleasedByUserID, int ReleaseApplicationID)
		{
			return clsDetainLicense.ReleaseDetainedLicense(this.DetainID,
				   ReleasedByUserID, ReleaseApplicationID);
		}

	}
}