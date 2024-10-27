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
public class SpecialistConsultationVisitor : IHealthcareVisitor
{
    public void VisitPediatricPatient(PediatricPatient patient)
    {
        Console.WriteLine($"\nSpecialist Consultation for Pediatric Patient: {patient.Name}");
        Console.WriteLine("- Pediatric Development Assessment");
        Console.WriteLine("- Behavioral Health Screening");
        Console.WriteLine($"- Reviewing Medical History: {patient.MedicalHistory}");
    }

    public void VisitAdultPatient(AdultPatient patient)
    {
        Console.WriteLine($"\nSpecialist Consultation for Adult Patient: {patient.Name}");
        Console.WriteLine("- Occupation-Related Health Assessment");
        Console.WriteLine("- Stress Management Evaluation");
        Console.WriteLine($"- Lifestyle Recommendations for: {patient.LifestyleFactors}");
    }

    public void VisitElderlyPatient(ElderlyPatient patient)
    {
        Console.WriteLine($"\nSpecialist Consultation for Elderly Patient: {patient.Name}");
        Console.WriteLine("- Geriatric Assessment");
        Console.WriteLine("- Medication Interaction Review:");
        foreach (var medication in patient.CurrentMedications)
        {
            Console.WriteLine($"  * Checking interactions for: {medication}");
        }
        Console.WriteLine("- Mobility and Balance Assessment");
    }
}

