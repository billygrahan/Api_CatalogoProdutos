using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(`Nome`,`Descricao`,`Preco`,`ImagemUrl`,`Estoque`,`DataCadastro`,`CategoriaId`) " +
                "VALUES('coca-cola','refrigerante de coca 350 ml',5.45,'cocacola.png',50,now(),1)");
            migrationBuilder.Sql("INSERT INTO Produtos(`Nome`,`Descricao`,`Preco`,`ImagemUrl`,`Estoque`,`DataCadastro`,`CategoriaId`) " +
                "VALUES('lanche de atum','lanche de atum com maionese',8.50,'atum.png',10,now(),2)");
            migrationBuilder.Sql("INSERT INTO Produtos(`Nome`,`Descricao`,`Preco`,`ImagemUrl`,`Estoque`,`DataCadastro`,`CategoriaId`) " +
                "VALUES('pudim','pudim de leite 100g',7.50,'pudim.png',20,now(),3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
