// Create patients
using DemoLibrary.ConcreteComponents;
using DemoLibrary.ConcreteVisitors;

var pediatricPatient = new PediatricPatient(
    "Tommy Smith",
    5,
    "Sarah Smith",
    "Up to date on all vaccinations",
    "Mild asthma"
);

var adultPatient = new AdultPatient(
    "John Doe",
    35,
    "Software Developer",
    "Sedentary work, regular exercise",
    "No significant issues"
);

var elderlyPatient = new ElderlyPatient(
    "Martha Johnson",
    75,
    new List<string> { "Lisinopril", "Metformin", "Vitamin D" },
    "Robert Johnson (Son) - 555-0123",
    "Hypertension, Type 2 Diabetes"
);

// Create visitors for different types of checkups
var generalCheckup = new GeneralCheckupVisitor();
var specialistConsultation = new SpecialistConsultationVisitor();
var preventiveScreening = new PreventiveScreeningVisitor();

// Perform different types of checkups for each patient
Console.WriteLine("=== Annual Health Checkup Process ===");

// Pediatric Patient Checkups
Console.WriteLine("\n--- Pediatric Patient Checkups ---");
pediatricPatient.Accept(generalCheckup);
pediatricPatient.Accept(specialistConsultation);
pediatricPatient.Accept(preventiveScreening);

// Adult Patient Checkups
Console.WriteLine("\n--- Adult Patient Checkups ---");
adultPatient.Accept(generalCheckup);
adultPatient.Accept(specialistConsultation);
adultPatient.Accept(preventiveScreening);

// Elderly Patient Checkups
Console.WriteLine("\n--- Elderly Patient Checkups ---");
elderlyPatient.Accept(generalCheckup);
elderlyPatient.Accept(specialistConsultation);
elderlyPatient.Accept(preventiveScreening);