// Java
public class DeadFish {
    public static int[] parse(String data) {
        int num = 0;
        int count = 0;
        int[] nums = new int[1000];

        for(int i = 0; i < data.length(); i++) {
          switch(data.charAt(i)) {
            case 'i': 
              num++;
              break;
            case 'd':
              num--;
              break;
            case 's':
              num *= num;
              break;
            case 'o':
              nums[count++] = num;
              break;
          }
        }

        int[] numsArr = new int[count];
        for(int i = 0; i < count; i++) 
          numsArr[i] = nums[i];

        return numsArr;
      }
}
