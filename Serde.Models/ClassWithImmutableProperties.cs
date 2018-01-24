namespace Serde.Models {
  public class ClassWithImmutableProperties : IYo {
    public ClassWithImmutableProperties(int zo) {
      this.Yo = zo;
    }

    public int Yo { get; }
  }
}
