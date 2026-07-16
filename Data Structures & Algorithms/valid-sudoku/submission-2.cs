public class Solution {
   
  public bool IsValidSudoku(char[][] board)
    {
        Dictionary<int,HashSet<char>> mapRows = new ();
        Dictionary<int, HashSet<char>>mapCols = new();
        Dictionary<string, HashSet<char>> mapGrids = new();
        
        int k = 0;
        
        foreach (var ch in board)
        {
            HashSet<char> row = new();

            for (int i = 0; i < ch.Length; i++)
            {
                if (!mapRows.ContainsKey(k))
                {
                    row.Add(ch[i]);
                    mapRows.Add(k, row);
                }
                else
                {
                  
                    
                    if (ch[i]=='.')
                    { }
                    else if (!mapRows[k].Add(ch[i]))
                    {
                        return false; 
                    }
                }
            }
            
            k++;
        }

        foreach (var ch in board)
        {   
            for (int i = 0; i < ch.Length; i++)
            { 
                if (!mapCols.ContainsKey(i))
                {   
                    HashSet<char> columns = new();
                    columns.Add(ch[i]);
                    mapCols.Add(i, columns);
                }
                else
                {
                    if (ch[i]=='.')
                    { }
                    else if (!mapCols[i].Add(ch[i]))
                    {
                        return false; 
                    }
                }
            }
        }

        int j = 0; 
        string key = "a";
        string fKey = "";
        foreach (var ch in board)
        {
            if (j%3==0)
            {
                key+="b";
            }
            for (int i = 0; i < ch.Length; i++)
            {   
                if (i<3)
                {
                    fKey = key + "x";
                    if (!mapGrids.ContainsKey(fKey))
                    {  
                        HashSet<char> grids = new();
                        grids.Add(ch[i]);
                        mapGrids.Add(fKey, grids);
                    }
                    else
                    {
                        if (ch[i]=='.')
                        { }
                        else if (!mapGrids[fKey].Add(ch[i]))
                        {
                            return false;
                        } 
                    }
                }
                else if(i<6)
                {   
                    fKey = key + "y";
                    if (!mapGrids.ContainsKey(fKey))
                    {   
                        HashSet<char> grids = new();
                        grids.Add(ch[i]);
                        mapGrids.Add(fKey, grids);
                    }
                    else
                    {
                        if (ch[i]=='.')
                        { }
                        else if (!mapGrids[fKey].Add(ch[i]))
                        {
                            return false;
                        }
                    }
                }
                else
                {   fKey = key + "z";
                    if (!mapGrids.ContainsKey(fKey))
                    {   
                        HashSet<char> grids = new();
                        grids.Add(ch[i]);
                        mapGrids.Add(fKey, grids);
                    }
                    else
                    {
                        if (ch[i]=='.')
                        { }
                        else if (!mapGrids[fKey].Add(ch[i]))
                        {
                            return false;
                        }
                    }
                }
            }

            j++;
        }
        
        
        return true;
    }
}
