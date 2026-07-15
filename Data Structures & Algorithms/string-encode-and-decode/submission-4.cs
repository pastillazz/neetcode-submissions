public class Solution {

    Dictionary<int, string> mapa =new();
    public string Encode(IList<string> strs) 
    { 
      string response="";
     for(int i=0; i<strs.Count; i++)
     {
      string str=strs[i];
        mapa.Add(i, str);
     }

     foreach(var num in mapa.Keys){
      response+=$"{num}_";
     }
     return response;
    }

    public List<string> Decode(string s) {
     
     List<string> list2=new();
     string cut="";
     for(int i=0; i<s.Length; i++)
     {
       char c=s[i];

      if(c=='_'){
        if(cut.Length>0){

          var respu=mapa[int.Parse(cut)];
          list2.Add(respu);
          cut="";
        }
      }
      else{
       cut+=c;
      }
      
     }
     
    return list2;
   }
}
