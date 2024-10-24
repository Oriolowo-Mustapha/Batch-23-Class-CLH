// Doctors
//DoctorDB.CreateDoctorDB();
//DoctorDB.CreateDoctorTable();
DoctorDB.RetrieveFromDb();
// Patient
//PatientDB.CreatePatientDB();
//PatientDB.CreatePatientTable();
PatientDB.RetrieveFromDb();

// Appointment
//AppointmentDb.CreateAppointmentDB();
//AppointmentDb.CreateAppointmentTable();
//AppointmentDb.CreateAcceptedAppointmentTable();
//AppointmentDb.CreateDeclinedAppointmentTable();
//AppointmentDb.CreateRequestedAppointmentByPatientTable();
//AppointmentDb.CreateCancelledAppointmentTable();
AppointmentDb.RetrieveFromDb();
AppointmentDb.RetrieveFromRequestedDb();

//MedicalRecordDB.CreateMedicalRecordDB();
MedicalRecordDB.CreateMedicalRecordTable();

Console.WriteLine("WELCOME TO A HEALTH CARE MANAGEMENT SYSTEM");
Menu.MainMenu();
