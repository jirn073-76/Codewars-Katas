// Java 

// Solved using type erasure

public class escapingTheMatrix {
  private static <T extends Throwable> T sneakyThrowInner(Throwable ex) throws T {
      throw (T)ex;
  }

  public static void enter() {
      escapingTheMatrix.<RuntimeException>sneakyThrowInner(new Neo());
  }
}
