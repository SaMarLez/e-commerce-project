//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VoltShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public productos()
        {
            this.descripcionCompra = new HashSet<descripcionCompra>();
            this.descripcionVenta = new HashSet<descripcionVenta>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string descripcion { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public Nullable<int> estado { get; set; }
        public Nullable<System.DateTime> creado { get; set; }
        public Nullable<System.DateTime> modificado { get; set; }
    
        public virtual categorias categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<descripcionCompra> descripcionCompra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<descripcionVenta> descripcionVenta { get; set; }
    }
}