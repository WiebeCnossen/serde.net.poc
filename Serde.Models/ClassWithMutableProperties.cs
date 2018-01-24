namespace Serde.Models {
  using System;

  public class ClassWithMutableProperties : IXo, IYo, IZo {
    public ClassWithMutableProperties(int? zo) {
      this.Xo = zo ?? throw new ArgumentNullException(nameof(zo));
    }

    public int Xo { get; set; }
    public int Yo { get; set; }
    public int Zo { get; set; }
  }
}
