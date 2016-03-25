using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SetupParameterLibrary.Data.Models
{
    public enum SetupDataType
    {
        _String = 0,
        _Float = 1,
        _Integer = 2,
        _Boolean = 3
    }

    [Table("SetupTranslator")]
    class SetupTranslatorModel
    {
        #region properties
        [Key(), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Guid SetupTranslatorId { get; set; }     
        [Required, MaxLength(50)]
        public virtual string Name { get; set; }
        [Required, MaxLength(16)]
        public virtual string OriginalSuffix { get; set; }
        [Required, MaxLength(16)]
        public virtual string TranslatedSuffix { get; set; }
        public virtual int Precision { get; set; }
        public virtual SetupDataType DataType { get; set; }
        #endregion

        #region ctor
        public SetupTranslatorModel()
        {

        }
        #endregion
    }
}
