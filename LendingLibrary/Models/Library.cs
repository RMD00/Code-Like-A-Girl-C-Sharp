namespace LendingLibrary.Models;
public class Library : Media
{
    public List<Novel> novels = new List<Novel>{};
    
    public void ListOfNovels()
    {
        foreach (var Novel in novels)
            {
               Novel.PrintNovel();
            }
    }



    public void AddNovel(Novel novel)
    {
        novels.Add(novel);    
    }

     public void AddTextbook(Textbook textbook)
    {
       // textbooks.Add();    
    }
}