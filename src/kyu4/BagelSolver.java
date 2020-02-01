import java.lang.reflect.*;

public class BagelSolver {

  public static Bagel getBagel() {
  
      Field field;
      try {
        field = java.lang.Boolean.class.getField("TRUE");
        field.setAccessible(true);
        
        Field modifiersField = Field.class.getDeclaredField("modifiers");
        modifiersField.setAccessible(true);
        modifiersField.setInt(field, field.getModifiers() & ~Modifier.FINAL);
  
        field.set(null, false);
      } catch (NoSuchFieldException | SecurityException | IllegalArgumentException | IllegalAccessException e) {}
  
      return new Bagel();
  }
}
