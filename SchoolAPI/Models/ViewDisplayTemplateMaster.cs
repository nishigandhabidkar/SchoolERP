namespace SchoolAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewDisplayTemplateMaster")]
    public partial class ViewDisplayTemplateMaster
    {
        [StringLength(50)]
        public string TemplateType { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? Status { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TemplateId { get; set; }

        public long? TemplateTypeId { get; set; }
    }
}