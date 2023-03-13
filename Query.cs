public class Query
{
    private Author authorJudas = new Author {
        Name = "Judas"
    };

    public Book GetBook() =>
        new Book
        {
            Title = "GraphQL with Hotchocolate",
            Author = authorJudas
        };
}