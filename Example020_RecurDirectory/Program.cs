// Как посмотреть содержимое папки? 
string path = @"C:\GB\C#\lesson01_c#\Example001_HelloConsole"; 
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i=0; i<fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}


void CatalogInfo(string path, string indent = "") // рекурсия ходим по папкам
{   
    DirectoryInfo catalogs = new DirectoryInfo(path);   
    foreach (var currentCatalog in catalogs.GetDirectories())   
    {       
        Console.WriteLine($"{indent}{currentCatalog.Name}");       
        CatalogInfo(currentCatalog.FullName, indent + "  ");   
    }   

    FileInfo[] files = catalogs.GetFiles();
    
    foreach (var item in catalogs.GetFiles())   
    {       
        Console.WriteLine($"{indent}{item.Name}");   
    } 
} 
// string path = @"C:\GB\C#\lesson01_c#\Example001_HelloConsole"; 
CatalogInfo(path);
