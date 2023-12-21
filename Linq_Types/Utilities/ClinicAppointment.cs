
internal class ClinicAppointment
{
    public int ClinicId { get; set; }
    public int PetId { get; set; }
    public DateTime DateTime { get; set; }

    public ClinicAppointment(int clinicId, int petId, DateTime dateTime)
    {
        ClinicId = clinicId;
        PetId = petId;
        DateTime = dateTime;
    }
}