namespace Serde.Poc.Models {
  public class ClassWithMutableProperties : IYo, IZo, IXo {
    public ClassWithMutableProperties(int zo) {
      this.Xo = zo;
    }

    public int Xo { get; set; }
    public int Yo { get; set; }
    public int Zo { get; set; }
  }
}
