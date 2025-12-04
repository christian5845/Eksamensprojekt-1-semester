using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.MockData;

namespace Eksamensprojekt_1_semester.Pages;

public class PHBådemedbeskrivelserModel : PageModel
{

    public List<TestBåd> Både
    {
        get; private set;

    } = new List<TestBåd>
    {
        new TestBåd("Tera",2.87,1.23,"Tera jollen er en moderne begynder-jolle, som kan sejles af unge fra 8 år og op. Det er en selvlænsende jolle, som ser godt ud, og som sejler godt.\r\n\r\nTera jollen sejler en smule hurtigere end en Optimist-jolle, og man kan træningsmæssigt uden problemer blande de to jolletyper."),
         new TestBåd("Feva",8.5,1,"test"),
         new TestBåd("Anne",8.5,1,"Test2")
    };
    public void OnGet()
    {
     
    }
}
