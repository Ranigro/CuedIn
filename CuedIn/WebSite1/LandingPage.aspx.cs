﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LandingPage : System.Web.UI.Page
{
    public static String[] imageArray = new string[5];
    public static String[] jobTitleArray = new string[5];
    public static int[] jobListingIDArray = new int[5];
    public static String[] orgNameArray = new string[5];
    public static String[] jobTypeArray = new string[5];
    public static String[] jobLocationArray = new string[5];
    public static int[] numOfapplicantsArray = new int[5];
    public static String[] jobDeadLineArray = new string[5];
    public static String[] jobDescArray = new string[5];
    public static String[] OrgDescArray = new string[5];


    protected void Page_Load(object sender, EventArgs e)
    {



        String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

        sql.Open();
        System.Data.SqlClient.SqlCommand RecentJobs = new System.Data.SqlClient.SqlCommand();
        RecentJobs.Connection = sql;
        RecentJobs.CommandText = "SELECT  TOP (5) JobListing.JobListingID, JobListing.JobTitle, Organization.Image, JobListing.Approved, Organization.OrganizationName, JobListing.JobType, JobListing.JobDescription, JobListing.Location,  JobListing.NumOfApplicants, JobListing.Deadline, Organization.OrganizationDescription FROM JobListing INNER JOIN Organization ON JobListing.OrganizationID = Organization.OrganizationEntityID WHERE (JobListing.Approved = 'P') ORDER BY JobListing.JobListingID DESC";
        System.Data.SqlClient.SqlDataReader reader = RecentJobs.ExecuteReader();


        int x = 0;

        while (reader.Read())
        {

            imageArray[x] = reader.GetString(2);
            jobTitleArray[x] = reader.GetString(1);
            jobListingIDArray[x] = reader.GetInt32(0);
            orgNameArray[x] = reader.GetString(4);
            jobTypeArray[x] = reader.GetString(5);
            jobLocationArray[x] = reader.GetString(7);
            jobDescArray[x] = reader.GetString(6);
            numOfapplicantsArray[x] = reader.GetInt32(8);
            jobDeadLineArray[x] = reader.GetDateTime(9).ToString();
            OrgDescArray[x] = reader.GetString(10);
            x++;

        }


        // First Card
        Image1.ImageUrl = imageArray[0];
        CompanyNamelbl.Text = orgNameArray[0];
        JobTitlelbl.Text = jobTitleArray[0];
        CompanyNamelbl2.Text = orgNameArray[0];
        lblJOrganizationDescription.Text = jobDescArray[0];
        lblJobType.Text = jobTypeArray[0];
        lblOrgDescription.Text = OrgDescArray[0];
        //lblJobLocatio.Text = jobLocationArray[0];
        //lblNumOfApplicants.Text = numOfapplicantsArray[0].ToString();
        //lblJobDeadline.Text = jobDeadLineArray[0];



        // Second card
        Image2.ImageUrl = imageArray[1];
        CompanyNamelbl3.Text = orgNameArray[1];
        JobTitlelbl2.Text = jobTitleArray[1];
        CompanyNamelbl4.Text = orgNameArray[1];
        lblJOrganizationDescription2.Text = jobDescArray[1];
        lblJobType2.Text = jobTypeArray[1];
        lblOrgDescription2.Text = OrgDescArray[1];


        // Third card
        Image3.ImageUrl = imageArray[2];
        CompanyNamelbl5.Text = orgNameArray[2];
        JobTitlelbl3.Text = jobTitleArray[2];
        CompanyNamelbl6.Text = orgNameArray[2];
        lblJOrganizationDescription3.Text = jobDescArray[2];
        lblJobType3.Text = jobTypeArray[2];
        lblOrgDescription3.Text = OrgDescArray[2];


        // Fourth card
        Image4.ImageUrl = imageArray[3];
        CompanyNamelbl7.Text = orgNameArray[3];
        JobTitlelbl4.Text = jobTitleArray[3];
        CompanyNamelbl8.Text = orgNameArray[3];
        lblJOrganizationDescription4.Text = jobDescArray[3];
        lblJobType4.Text = jobTypeArray[3];
        lblOrgDescription4.Text = OrgDescArray[3];


        sql.Close();





    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }





    




    protected void Icon1_Click(object sender, EventArgs e)
    {


        //String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        //System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

        //sql.Open();
        //System.Data.SqlClient.SqlCommand moreJobInfo = new System.Data.SqlClient.SqlCommand();
        //moreJobInfo.Connection = sql;
        //moreJobInfo.CommandText = "SELECT Organization.OrganizationName, Organization.OrganizationDescription, JobListing.JobTitle, JobListing.JobDescription, JobListing.JobType, JobListing.Location, JobListing.Deadline, JobListing.NumOfApplicants FROM Organization INNER JOIN JobListing ON Organization.OrganizationEntityID = JobListing.OrganizationID where JobListing.JobListingID = " + jobListingIDArray[0];
        //System.Data.SqlClient.SqlDataReader reader = moreJobInfo.ExecuteReader();



        //while (reader.Read())
        //{
        //    //set labels to db values
        //    lblJOrganizationName.Text = "Organization Name: " + reader.GetString(0);
        //    lblJOrganizationDescription.Text = "Organization Description: " + reader.GetString(1);
        //    lblJobName.Text = "Job Title: " + reader.GetString(2);
        //    lblJobDescription.Text = "Job Description: " + reader.GetString(3);
        //    lblJobType.Text = "Job Type: " + reader.GetString(4);
        //    lblJobLocation.Text = "Job Location: " + reader.GetString(5);
        //    lblJobDeadline.Text = "Job Deadline: " + reader.GetDateTime(6);
        //    lblNumOfApplicants.Text = "Number of Applicants: " + reader.GetInt32(7);

        //}

        //sql.Close();







    //    ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openIconModal();", true);

    //}

    //protected void Icon2_Click(object sender, EventArgs e)
    //{

    //    String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
    //    System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

    //    sql.Open();
    //    System.Data.SqlClient.SqlCommand moreJobInfo = new System.Data.SqlClient.SqlCommand();
    //    moreJobInfo.Connection = sql;
    //    moreJobInfo.CommandText = "SELECT Organization.OrganizationName, Organization.OrganizationDescription, JobListing.JobTitle, JobListing.JobDescription, JobListing.JobType, JobListing.Location, JobListing.Deadline, JobListing.NumOfApplicants FROM Organization INNER JOIN JobListing ON Organization.OrganizationEntityID = JobListing.OrganizationID where JobListing.JobListingID = " + jobListingIDArray[1];
    //    System.Data.SqlClient.SqlDataReader reader = moreJobInfo.ExecuteReader();



    //    while (reader.Read())
    //    {
    //        //set labels to db values
    //        lblJOrganizationName.Text = "Organization Name: " + reader.GetString(0);
    //        lblJOrganizationDescription.Text = "Organization Description: " + reader.GetString(1);
    //        lblJobName.Text = "Job Title: " + reader.GetString(2);
    //        lblJobDescription.Text = "Job Description: " + reader.GetString(3);
    //        lblJobType.Text = "Job Type: " + reader.GetString(4);
    //        lblJobLocation.Text = "Job Location: " + reader.GetString(5);
    //        lblJobDeadline.Text = "Job Deadline: " + reader.GetDateTime(6);
    //        lblNumOfApplicants.Text = "Number of Applicants: " + reader.GetInt32(7);

    //    }

    //    sql.Close();





    //    ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openIconModal();", true);
    //}

    //protected void Icon3_Click(object sender, EventArgs e)
    //{
    //    String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
    //    System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

    //    sql.Open();
    //    System.Data.SqlClient.SqlCommand moreJobInfo = new System.Data.SqlClient.SqlCommand();
    //    moreJobInfo.Connection = sql;
    //    moreJobInfo.CommandText = "SELECT Organization.OrganizationName, Organization.OrganizationDescription, JobListing.JobTitle, JobListing.JobDescription, JobListing.JobType, JobListing.Location, JobListing.Deadline, JobListing.NumOfApplicants FROM Organization INNER JOIN JobListing ON Organization.OrganizationEntityID = JobListing.OrganizationID where JobListing.JobListingID = " + jobListingIDArray[2];
    //    System.Data.SqlClient.SqlDataReader reader = moreJobInfo.ExecuteReader();



    //    while (reader.Read())
    //    {
    //        //set labels to db values
    //        lblJOrganizationName.Text = "Organization Name: " + reader.GetString(0);
    //        lblJOrganizationDescription.Text = "Organization Description: " + reader.GetString(1);
    //        lblJobName.Text = "Job Title: " + reader.GetString(2);
    //        lblJobDescription.Text = "Job Description: " + reader.GetString(3);
    //        lblJobType.Text = "Job Type: " + reader.GetString(4);
    //        lblJobLocation.Text = "Job Location: " + reader.GetString(5);
    //        lblJobDeadline.Text = "Job Deadline: " + reader.GetDateTime(6);
    //        lblNumOfApplicants.Text = "Number of Applicants: " + reader.GetInt32(7);

    //    }

    //    sql.Close();





    //    ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openIconModal();", true);
    //}

    //protected void Icon4_Click(object sender, EventArgs e)
    //{
    //    String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
    //    System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

    //    sql.Open();
    //    System.Data.SqlClient.SqlCommand moreJobInfo = new System.Data.SqlClient.SqlCommand();
    //    moreJobInfo.Connection = sql;
    //    moreJobInfo.CommandText = "SELECT Organization.OrganizationName, Organization.OrganizationDescription, JobListing.JobTitle, JobListing.JobDescription, JobListing.JobType, JobListing.Location, JobListing.Deadline, JobListing.NumOfApplicants FROM Organization INNER JOIN JobListing ON Organization.OrganizationEntityID = JobListing.OrganizationID where JobListing.JobListingID = " + jobListingIDArray[3];
    //    System.Data.SqlClient.SqlDataReader reader = moreJobInfo.ExecuteReader();



    //    while (reader.Read())
    //    {
    //        //set labels to db values
    //        lblJOrganizationName.Text = "Organization Name: " + reader.GetString(0);
    //        lblJOrganizationDescription.Text = "Organization Description: " + reader.GetString(1);
    //        lblJobName.Text = "Job Title: " + reader.GetString(2);
    //        lblJobDescription.Text = "Job Description: " + reader.GetString(3);
    //        lblJobType.Text = "Job Type: " + reader.GetString(4);
    //        lblJobLocation.Text = "Job Location: " + reader.GetString(5);
    //        lblJobDeadline.Text = "Job Deadline: " + reader.GetDateTime(6);
    //        lblNumOfApplicants.Text = "Number of Applicants: " + reader.GetInt32(7);

    //    }

    //    sql.Close();





    //    ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openIconModal();", true);
    //}

    //protected void Icon5_Click(object sender, EventArgs e)
    //{
    //    String connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
    //    System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection(connectionString);

    //    sql.Open();
    //    System.Data.SqlClient.SqlCommand moreJobInfo = new System.Data.SqlClient.SqlCommand();
    //    moreJobInfo.Connection = sql;
    //    moreJobInfo.CommandText = "SELECT Organization.OrganizationName, Organization.OrganizationDescription, JobListing.JobTitle, JobListing.JobDescription, JobListing.JobType, JobListing.Location, JobListing.Deadline, JobListing.NumOfApplicants FROM Organization INNER JOIN JobListing ON Organization.OrganizationEntityID = JobListing.OrganizationID where JobListing.JobListingID = " + jobListingIDArray[4];
    //    System.Data.SqlClient.SqlDataReader reader = moreJobInfo.ExecuteReader();



    //    while (reader.Read())
    //    {
    //        //set labels to db values
    //        lblJOrganizationName.Text = "Organization Name: " + reader.GetString(0);
    //        lblJOrganizationDescription.Text = "Organization Description: " + reader.GetString(1);
    //        lblJobName.Text = "Job Title: " + reader.GetString(2);
    //        lblJobDescription.Text = "Job Description: " + reader.GetString(3);
    //        lblJobType.Text = "Job Type: " + reader.GetString(4);
    //        lblJobLocation.Text = "Job Location: " + reader.GetString(5);
    //        lblJobDeadline.Text = "Job Deadline: " + reader.GetDateTime(6);
    //        lblNumOfApplicants.Text = "Number of Applicants: " + reader.GetInt32(7);

    //    }

    //    sql.Close();





    //    ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openIconModal();", true);
    }
}