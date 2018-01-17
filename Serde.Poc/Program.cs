namespace Serde.Poc {
  using System;

  using Newtonsoft.Json;

  using Serde.Poc.Models;

  internal static class Program {
    private static readonly string[] Jsons = { "{ yo: 42 }", "{ zo: 42 }", "{ yo: 42, zo: 42 }" };

    private static void FromJson<TResult>(string json) {
      try {
        var obj = JsonConvert.DeserializeObject<TResult>(json);
        Console.WriteLine($"{typeof(TResult).Name} => {JsonConvert.SerializeObject(obj)}");

        if (obj is IXo xo) {
          Console.WriteLine($"{typeof(TResult).Name}.Xo = {xo.Xo}");
        }

        if (obj is IYo yo) {
          Console.WriteLine($"{typeof(TResult).Name}.Yo = {yo.Yo}");
        }

        if (obj is IZo zo) {
          Console.WriteLine($"{typeof(TResult).Name}.Zo = {zo.Zo}");
        }
      }
      catch (Exception e) {
        Console.Error.WriteLine($"!! {typeof(TResult).Name}: {e.Message}");
      }
    }

    private static void Main() {
      foreach (var json in Jsons) {
        Console.WriteLine(json);
        FromJson<ClassWithMutableProperties>(json);
        FromJson<ClassWithImmutableProperties>(json);
        FromJson<ClassWithBackedImmutableProperties>(json);
        FromJson<StructWithImmutableProperties>(json);
        FromJson<StructWithBackedImmutableProperties>(json);
      }
    }
  }
}
