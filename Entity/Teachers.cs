//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_20._101_Kuzminyh_3.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teachers()
        {
            this.Attestation = new HashSet<Attestation>();
            this.DisciplineTeachers = new HashSet<DisciplineTeachers>();
        }
    
        public int IdTeachers { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public int IdStatusTeachers { get; set; }
        public Nullable<int> IdRole { get; set; }
        public int IdSpeciality { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attestation> Attestation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplineTeachers> DisciplineTeachers { get; set; }
        public virtual Role Role { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual StatusTeacher StatusTeacher { get; set; }
        public virtual SystemUser SystemUser { get; set; }
    }
}
