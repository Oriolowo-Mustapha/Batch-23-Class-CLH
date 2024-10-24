using System;

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
            switch(input)
            {
                case 1:
                    AllocateEmail();
                    break;
                case 2:
                    running = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    break;
            }
        }
    }

    public static void AllocateEmail()
    {
        Console.Write("ID=> ");
        int id = int.Parse(Console.ReadLine());
        var loggedInDoctor = DoctorFile.Login(id);
        var loggedInPatient = PatientFile.Login(id);
        var loggedInAdmin = Admin.Login(id);
        var getCount = AppointmentFile.Get();
        if ( loggedInDoctor != null)
        {
            doctorMenu(loggedInDoctor);
        }
        else if(loggedInPatient != null)
        {
            patientMenu(loggedInPatient);
        }
        else if (loggedInAdmin != null)
        {
            if (getCount == 0)
            {
                adminMenu(loggedInAdmin);
            }
            AppointmentFile.RescheduleDeclined(loggedInAdmin);
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
                    AppointmentFile.GetAppointmentByDoctorID(loggedInDoctor.DoctorID);
                    break;
                case 2:
                    int id = loggedInDoctor.DoctorID;
                    PatientFile.SearchPatient(id);
                    break;
                case 3:
                    MedicalRecordFile.AddMedicalRecord();
                    break;
                case 4:
                    Console.Write("Patient ID=> ");
                    int patientId = loggedInDoctor.DoctorID;
                    MedicalRecordFile.ViewPatientMedicalRecord(patientId);
                    break;
                case 5:
                    Console.Write("Patient ID=> ");
                    int patientId2 = loggedInDoctor.DoctorID;
                    MedicalRecordFile.UpdateRecord(patientId2);
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
            Console.WriteLine("1. VIEW APPOINTMENTS.");
            Console.WriteLine("2. VIEW PERSONAL INFO.");
            Console.WriteLine("3. VIEW MEDICAL RECORD");
            Console.WriteLine("4. CANCEL APPOINTMENT.");
            Console.WriteLine("5. UPDATE PERSONAL INFO.");
            Console.WriteLine("6. LOGOUT.");
            Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    AppointmentFile.GetAppointmentByPatientID(loggedInPatient.PatientID);
                    break;
                case 2:
                    PatientFile.SearchPatient(loggedInPatient.PatientID);
                    break;
                case 3:
                    MedicalRecordFile.ViewPatientMedicalRecord(loggedInPatient.PatientID);
                    break;
                case 4:
                    AppointmentFile.CancelAppointment();
                    break;
                case 5:
                    PatientFile.UpdatePatientRecord(loggedInPatient.PatientID);
                    break;
                case 6:
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
        var getCount = AppointmentFile.Get();
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. ADD PATIENT.");
            Console.WriteLine("2. ADD DOCTOR.");
            Console.WriteLine("3. VIEW ALL PATIENT");
            Console.WriteLine("4. VIEW ALL DOCTORS.");
            Console.WriteLine("5. SEARCH DOCTOR.");
            Console.WriteLine("6. SEARCH PATIENT.");
            Console.WriteLine("7. DELETE DOCTOR.");
            Console.WriteLine("8. DELETE PATIENT.");
            Console.WriteLine("9. SHEDULE APPOINTMENT.");
            Console.WriteLine("10. RESHEDULE APPOINTMENT");
            Console.WriteLine("11. VIEW ALL APPOINTMENT.");
            Console.WriteLine("12. VIEW ACCEPTED APPOINTMENT.");
            Console.WriteLine("13. LOGOUT.");
            Console.Write("CHOOSE ANY OF THE FOLLOWING OPTIONS TO CONTINUE=> ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    PatientFile.AddPatient();
                    break;
                case 2:
                    DoctorFile.AddDoctor();
                    break;
                case 3:
                    PatientFile.ViewAllPatients();
                    break;
                case 4:
                    DoctorFile.ViewAllDoctors();
                    break;
                case 5:
                    Console.Write("Doctor ID=> ");
                    int doctorID = int.Parse(Console.ReadLine());
                    DoctorFile.SearchDoctor(doctorID);
                    break;
                case 6:
                    Console.Write("Patient ID=> ");
                    int patientID = int.Parse(Console.ReadLine());
                    DoctorFile.SearchDoctor(patientID);
                    break;
                case 7:
                    DoctorFile.DeleteDoctor();
                    break;
                case 8:
                    PatientFile.DeletePatient();
                    break;
                case 9:
                    if (getCount == 0)
                    {
                        AppointmentFile.ScheduleAppointment2();
                    }
                    AppointmentFile.ScheduleAppointment();

                    break;
                case 10:
                    Console.Write("Appointment ID=> ");
                    int appointID = int.Parse(Console.ReadLine());
                    AppointmentFile.RescheduleAppointment(appointID);

                    break;
                case 11:
                    AppointmentFile.GetAllAppointment();
                    break;
                case 12:
                    AppointmentFile.GetAllAcceptedAppointment();
                    break;
                case 13:
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
