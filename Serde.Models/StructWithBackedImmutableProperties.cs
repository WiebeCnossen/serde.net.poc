namespace Serde.Models {
  public struct StructWithBackedImmutableProperties : IXo, IYo, IZo {
    public StructWithBackedImmutableProperties(int yo) {
      this.Zo = yo;
    }

    int IXo.Xo => this.Yo;
    public int Yo => 2 * this.Zo;
    public int Zo { get; }
  }
}
