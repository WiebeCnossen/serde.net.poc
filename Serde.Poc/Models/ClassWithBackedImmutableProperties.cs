namespace Serde.Poc.Models {
  using System;

  using Newtonsoft.Json;

  public class ClassWithBackedImmutableProperties : IYo {
    private readonly int yoBacking;

    [JsonConstructor]
    public ClassWithBackedImmutableProperties(int? yo) {
      this.yoBacking = yo ?? throw new ArgumentNullException(nameof(yo));
    }

    public ClassWithBackedImmutableProperties(int zo) {
      this.yoBacking = zo;
    }

    public int Yo => 2 * this.yoBacking;
  }
}
