namespace EFCoreRelationshipsTutorial.Models;

public class Student
{
    public int Id { get; set; }
    public int StoreId { get; set; }
    public string Name { get; set; }
       
    public StudentAddress Address { get; set; }
}