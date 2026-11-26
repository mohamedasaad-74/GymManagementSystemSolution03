namespace GymManagementSystem.Entities.Enums
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public String? CreatedBy { get; set; }
    }
}
