﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class Constant
{
    public static readonly string ExceptionMessage = "Something went wrong. Please try after sometime.";
    public static readonly string TryingToAccessDeletedAccount = "You are trying to access your deleted account, Please try 'ForgotPassword' feature for your account recovery or contact Mapoltic team to sign up again.";
    public static readonly string ServerError = "Something went wrong, please try again after sometime";
    public static readonly string SuccessfulLogin = "Login successful";
    public static readonly string FailedLogin = "Username or password is wrong";
    public static readonly string AddSuccess = "Added successfully";
    public static readonly string UpdateSuccess = "Updated successfully";
    public static readonly string PasswordChange = "Password Changed Successfully";

    public static readonly string SentEmail = "Email Successfully sent.";
    public static readonly string NotFound = "Not found.";
    public static readonly string NotFound1 = "{0} Not found.";
    public static readonly string NoPtmFound = "No Ptm found.";
    public static readonly string NoChildFound = "No Child found with this id.";
    public static readonly string NoParentFound = "No Parent found with this id.";
    public static readonly string NoTeacherFound = "No Teacher found with this id.";

    public static readonly string AllAppointments = "All Appointments fetched successfully";
    public static readonly string Appointment = "Appointment fetched";
    public static readonly string AppointmentDeleted = "Appointment deleted successfully";
    public static readonly string UpdateAppointment = "Appointment updated successfully";
    public static readonly string NoAppointmentFound = "No Appointment found with this id";

    public static readonly string TimeslotFetched = "Timeslot fetched successfully";
    public static readonly string TimeslotUpdated = "Timeslot status updated successfully";

    public static readonly string NoIdFound = "Not found with this id found";
    public static readonly string Duplicate = "Duplicate Data";

    public static readonly string Fetched = "Fetched successfully";
    public static readonly string UnauthorizedAccess = "{0} You are unauthorized to access this";

}



