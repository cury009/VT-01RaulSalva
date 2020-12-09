namespace VT_01RaulSalva.Pages
{
    public String referencia { set; get; }
    public String tipo { set; get; }
    public String marca { set; get; }
    public String precio { set; get; }
    public String stock { set; get; }
    public DateTime fechaAlta { set; get; }

    public Producto(string referencia, string tipo, string marca, string precio, string stock, DateTime fechaAlta)
    {
        this.referencia = referencia;
        this.tipo = tipo;
        this.marca = marca;
        this.precio = precio;
        this.stock = stock;
        this.fecha = fechaAlta;
    }
    public Producto()
    {
        this.referencia = "";
        this.tipo = "";
        this.marca = "";
        this.telefono = "";
        this.stock = "";
        this.fechaAlta = DateTime.Now;
    }

    public override string ToString()
    {
        return referncia;
    }

    public object Clone()
    {
        return this.MemberwiseClone();

    }
}