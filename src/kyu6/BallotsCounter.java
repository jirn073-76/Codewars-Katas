import java.util.List;
import java.util.Map.Entry;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;

public class BallotsCounter {

  public static String getWinner(final List<String> listOfBallots) {
      
        HashMap<String, Integer> dict = new HashMap<String, Integer>();
        
        for(String vote: listOfBallots) {
          if(dict.containsKey(vote)) 
            dict.put(vote, dict.get(vote)+1);
          else 
            dict.put(vote, 1);
        }
        
        Entry<String, Integer>[] sortedDict = new Entry[dict.size()];
        int i = 0;
        for(Entry<String, Integer> obj: dict.entrySet()) 
          sortedDict[i++] = obj;
        
        Arrays.sort(sortedDict, new Comparator<Entry<String, Integer>>() {
                @Override
                public int compare(Entry<String, Integer> o1, Entry<String, Integer> o2) {
                  return o2.getValue().compareTo(o1.getValue());
                }
            });
        
        return sortedDict[0].getValue() > listOfBallots.size()/2 ? sortedDict[0].getKey() : null;
    }
}
