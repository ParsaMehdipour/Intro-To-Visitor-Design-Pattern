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
public class PreventiveScreeningVisitor : IHealthcareVisitor
{
    public void VisitPediatricPatient(PediatricPatient patient)
    {
        Console.WriteLine($"\nPreventive Screening for Pediatric Patient: {patient.Name}");
        Console.WriteLine("- Vision and Hearing Tests");
        Console.WriteLine("- Developmental Milestone Assessment");
        Console.WriteLine($"- Guardian Consultation with: {patient.GuardianName}");
    }

    public void VisitAdultPatient(AdultPatient patient)
    {
        Console.WriteLine($"\nPreventive Screening for Adult Patient: {patient.Name}");
        Console.WriteLine("- Cancer Screening Based on Age and Risk Factors");
        Console.WriteLine("- Cardiovascular Health Assessment");
        Console.WriteLine($"- Occupation-Related Risk Screening: {patient.Occupation}");
    }

    public void VisitElderlyPatient(ElderlyPatient patient)
    {
        Console.WriteLine($"\nPreventive Screening for Elderly Patient: {patient.Name}");
        Console.WriteLine("- Osteoporosis Screening");
        Console.WriteLine("- Cognitive Function Assessment");
        Console.WriteLine("- Fall Risk Evaluation");
        Console.WriteLine($"- Emergency Contact Notified: {patient.EmergencyContact}");
    }
}
