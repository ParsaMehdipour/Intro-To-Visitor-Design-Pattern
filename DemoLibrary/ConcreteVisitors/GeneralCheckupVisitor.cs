using DemoLibrary.ConcreteComponents;
using DemoLibrary.VisitorInterfaces;

namespace DemoLibrary.ConcreteVisitors;

/// <summary>
/// Concrete Visitors implement several versions of the same algorithm, which
/// can work with all concrete component classes.
///
/// You can experience the biggest benefit of the Visitor pattern when using
/// it with a complex object structure, such as a Composite tree. In this
/// case, it might be helpful to store some intermediate state of the
/// algorithm while executing visitor's methods over various objects of the
/// structure.
/// </summary>
public class GeneralCheckupVisitor : IHealthcareVisitor
{
    public void VisitPediatricPatient(PediatricPatient patient)
    {
        Console.WriteLine($"\nPerforming General Checkup for Pediatric Patient: {patient.Name}");
        Console.WriteLine("- Checking growth and development metrics");
        Console.WriteLine("- Reviewing vaccination record");
        Console.WriteLine($"- Vaccination Status: {patient.VaccinationRecord}");
        Console.WriteLine($"- Consulting with Guardian: {patient.GuardianName}");
    }

    public void VisitAdultPatient(AdultPatient patient)
    {
        Console.WriteLine($"\nPerforming General Checkup for Adult Patient: {patient.Name}");
        Console.WriteLine("- Checking vital signs");
        Console.WriteLine("- Reviewing lifestyle factors");
        Console.WriteLine($"- Occupation-related health concerns: {patient.Occupation}");
        Console.WriteLine($"- Lifestyle Assessment: {patient.LifestyleFactors}");
    }

    public void VisitElderlyPatient(ElderlyPatient patient)
    {
        Console.WriteLine($"\nPerforming General Checkup for Elderly Patient: {patient.Name}");
        Console.WriteLine("- Comprehensive vital signs check");
        Console.WriteLine("- Reviewing current medications:");
        foreach (var medication in patient.CurrentMedications)
        {
            Console.WriteLine($"  * {medication}");
        }
        Console.WriteLine($"- Emergency Contact: {patient.EmergencyContact}");
    }
}
