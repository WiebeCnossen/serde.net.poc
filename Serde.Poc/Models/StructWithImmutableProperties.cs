namespace Serde.Poc.Models {
  public struct StructWithImmutableProperties : IYo {
    public StructWithImmutableProperties(int yo) {
      this.Yo = yo;
    }

    public int Yo { get; }
  }
}
