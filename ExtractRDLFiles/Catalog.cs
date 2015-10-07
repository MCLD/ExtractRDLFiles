namespace ExtractRDLFiles {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Catalog")]
    public partial class Catalog {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Catalog() {
            Catalog1 = new HashSet<Catalog>();
            Catalog11 = new HashSet<Catalog>();
        }

        [Key]
        public Guid ItemID { get; set; }

        [Required]
        [StringLength(425)]
        public string Path { get; set; }

        [Required]
        [StringLength(425)]
        public string Name { get; set; }

        public Guid? ParentID { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "image")]
        public byte[] Content { get; set; }

        public Guid? Intermediate { get; set; }

        public Guid? SnapshotDataID { get; set; }

        public Guid? LinkSourceID { get; set; }

        [Column(TypeName = "ntext")]
        public string Property { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public bool? Hidden { get; set; }

        public Guid CreatedByID { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid ModifiedByID { get; set; }

        public DateTime ModifiedDate { get; set; }

        [StringLength(260)]
        public string MimeType { get; set; }

        public int? SnapshotLimit { get; set; }

        [Column(TypeName = "ntext")]
        public string Parameter { get; set; }

        public Guid PolicyID { get; set; }

        public bool PolicyRoot { get; set; }

        public int ExecutionFlag { get; set; }

        public DateTime? ExecutionTime { get; set; }

        [StringLength(128)]
        public string SubType { get; set; }

        public Guid? ComponentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catalog> Catalog1 { get; set; }

        public virtual Catalog Catalog2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Catalog> Catalog11 { get; set; }

        public virtual Catalog Catalog3 { get; set; }
    }
}
