//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrograIV_4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Disco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disco()
        {
            this.Cancion = new HashSet<Cancion>();
            this.DiscoVenta = new HashSet<DiscoVenta>();
        }
    
        public int dis_id { get; set; }
        public string dis_alb { get; set; }
        public double dis_val { get; set; }
        public int gen_id { get; set; }
        public int aut_id { get; set; }
    
        public virtual Autor Autor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cancion> Cancion { get; set; }
        public virtual Genero Genero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscoVenta> DiscoVenta { get; set; }
    }
}
