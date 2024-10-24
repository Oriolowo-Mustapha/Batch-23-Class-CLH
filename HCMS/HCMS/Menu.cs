public class Menu
{
    public static void MainMenu()
    {
        Console.WriteLine("1. LOGIN.");
        Console.WriteLine("2. EXIT.");
        Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
        int input = int.Parse(Console.ReadLine());
        bool running = true;
        while (running)
        {
            switch (input)
            {
                case 1:
                    AllocateEmail();
                    break;
                case 2:
                    running = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
                    input = int.Parse(Console.ReadLine());
                    break;
            }
        }
    }

    public static void AllocateEmail()
    {
        Console.Write("ID=> ");
        int id = int.Parse(Console.ReadLine());
        var loggedInDoctor = DoctorDB.DoctorLogin(id);
        var loggedInPatient = PatientDB.PatientLogin(id);
        var loggedInAdmin = Admin.Login(id);
        if (loggedInDoctor != null)
        {
            doctorMenu(loggedInDoctor);
        }
        else if (loggedInPatient != null)
        {
            patientMenu(loggedInPatient);
        }
        else if (loggedInAdmin != null)
        {
            adminMenu(loggedInAdmin);
        }
        else
        {
            Console.WriteLine("INVALID ID.");
            AllocateEmail();
        }
    }

    public static void doctorMenu(Doctor loggedInDoctor)
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. VIEW APPOINTMENTS.");
            Console.WriteLine("2. SEARCH PATIENT");
            Console.WriteLine("3. ADD MEDICAL RECORD");
            Console.WriteLine("4. VIEW PATIENT MEDICAL RECORD.");
            Console.WriteLine("5. UPDATE MEDICAL RECORD.");
            Console.WriteLine("6. LOGOUT.");
            Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AppointmentDb.GetAppointmentByDoctorID(loggedInDoctor);
                    break;
                case 2:
                    Console.Write("Enter Patient Name: ");
                    string patName = Console.ReadLine().ToUpper();
                    PatientDB.GetPatient(patName);
                    break;
                case 3:
                    MedicalRecordDB.AddMedicalRecord(loggedInDoctor);
                    break;
                case 4:
                    Console.Write("PatientID");
                    int patientID = int.Parse(Console.ReadLine());
                    MedicalRecordDB.GetPatientMedicalRecords(patientID);
                    break;
                case 5:
                    Console.Write("Enter Patient Name: ");
                    string patName2 = Console.ReadLine().ToUpper();
                    MedicalRecordDB.UpdateRecord(patName2);
                    break;
                case 6:
                    run = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    doctorMenu(loggedInDoctor);
                    break;

            }
        }
        MainMenu();
    }

    public static void patientMenu(Patient loggedInPatient)
    {
        bool run = true;
        while (run)
        {
            AppointmentDb.GetAccepted(loggedInPatient.PatientID);
            AppointmentDb.GetDeclined(loggedInPatient.PatientID);
            Console.WriteLine("1. REQUEST TO SCHEDULE APPOINTMENTS.");
            Console.WriteLine("2. VIEW APPOINTMENTS.");
            Console.WriteLine("3. VIEW PERSONAL INFO.");
            Console.WriteLine("4. VIEW MEDICAL RECORD");
            Console.WriteLine("5. CANCEL APPOINTMENT.");
            Console.WriteLine("6. UPDATE PERSONAL INFO.");
            Console.WriteLine("7. LOGOUT.");
            Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AppointmentDb.RequestScheduleAppointmentByPatient(loggedInPatient);
                    break;
                case 2:
                    AppointmentDb.GetAppointmentByPatientID(loggedInPatient);
                    break;
                case 3:
                    PatientDB.ViewPersonalInfo(loggedInPatient.PatientID);
                    break;
                case 4:
                    MedicalRecordDB.GetPatientMedicalRecords(loggedInPatient.PatientID);
                    break;
                case 5:
                    AppointmentDb.CancelAppointment(loggedInPatient);
                    break;
                case 6:
                    PatientDB.UpdatePersonalInfo(loggedInPatient);
                    break;
                case 7:
                    run = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    patientMenu(loggedInPatient);
                    break;

            }
        }
        MainMenu();
    }

    public static void adminMenu(Admin admin)
    {
        bool run = true;
        while (run)
        {
            AppointmentDb.CheckIfRequested();
            AppointmentDb.GetCancelled();
            Console.WriteLine("1. ADD PATIENT.");
            Console.WriteLine("2. ADD DOCTOR.");
            Console.WriteLine("3. VIEW ALL PATIENT");
            Console.WriteLine("4. VIEW ALL DOCTORS.");
            Console.WriteLine("5. SEARCH DOCTOR.");
            Console.WriteLine("6. SEARCH PATIENT.");
            Console.WriteLine("7. DELETE DOCTOR.");
            Console.WriteLine("8. DELETE PATIENT.");
            Console.WriteLine("9. SCHEDULE APPOINTMENT.");
            Console.WriteLine("10. SCHEDULE REQUESTED APPOINTMENT.");
            Console.WriteLine("11. RESCHEDULE APPOINTMENT");
            Console.WriteLine("12. VIEW ALL APPOINTMENT.");
            Console.WriteLine("13. VIEW ALL ACCEPTED APPOINTMENT.");
            Console.WriteLine("14. VIEW ALL DECLINED APPOINTMENT.");
            Console.WriteLine("15. VIEW ALL CANCELLED APPOINTMENT.");
            Console.WriteLine("16. VIEW ALL ENDED APPOINTMENT.");
            Console.WriteLine("17. LOGOUT.");
            Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    PatientDB.AddPatient();
                    break;
                case 2:
                    DoctorDB.AddDoctor();
                    break;
                case 3:
                    PatientDB.GetAllPatient();
                    break;
                case 4:
                    DoctorDB.GetAllDoctors();
                    break;
                case 5:
                    Console.Write("Enter Doctor Name: ");
                    string docName = Console.ReadLine().ToUpper();
                    DoctorDB.GetDoctor(docName);
                    break;
                case 6:
                    Console.Write("Enter Patient Name: ");
                    string patName = Console.ReadLine().ToUpper();
                    PatientDB.GetPatient(patName);
                    break;
                case 7:
                    DoctorDB.DeleteDoctor();
                    break;
                case 8:
                    PatientDB.DeletePatient();
                    break;
                case 9:
                    AppointmentDb.ScheduleAppointment();
                    break;
                case 10:
                    AppointmentDb.ScheduleAppointmentRequestedByPatient();
                    break;
                case 11:
                    Console.Write("Appointment ID: ");
                    int id = int.Parse(Console.ReadLine());
                    AppointmentDb.RescheduleAppointment(id);
                    break;
                case 12:
                    AppointmentDb.ViewAllAppointments();
                    break;
                case 13:
                    AppointmentDb.ViewAllAcceptedAppointments();
                    break;
                case 14:
                    AppointmentDb.ViewAllDeclinedAppointments();
                    break;
                case 15:
                    AppointmentDb.ViewAllCancelledAppointments();
                    break;
                case 16:
                    AppointmentDb.ViewAllEndedAppointments();
                    break;
                case 17:
                    run = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    adminMenu(admin);
                    break;

            }
        }
        MainMenu();
    }
}
