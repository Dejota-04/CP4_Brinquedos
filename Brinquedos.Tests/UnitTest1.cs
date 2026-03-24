using Brinquedos.Api.Controllers;
using Brinquedos.Api.Data;
using Brinquedos.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Brinquedos.Tests
{
    public class BrinquedosControllerTests
    {
        private AppDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            return new AppDbContext(options);
        }

        [Fact]
        public async Task GetBrinquedos_DeveRetornarTodosOsBrinquedos()
        {
            // Arrange
            var context = GetDbContext();
            context.Brinquedos.Add(new Brinquedo { Id_brinquedo = 1, Nome_brinquedo = "Bola", Tipo_brinquedo = "Esporte", Classificacao = "Livre", Tamanho = "Pequeno", Preco = 20 });
            context.Brinquedos.Add(new Brinquedo { Id_brinquedo = 2, Nome_brinquedo = "Boneca", Tipo_brinquedo = "Ação", Classificacao = "Livre", Tamanho = "Médio", Preco = 50 });
            await context.SaveChangesAsync();
            var controller = new BrinquedosController(context);

            // Act
            var actionResult = await controller.GetBrinquedos();

            // Assert
            var result = actionResult.Value;
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetBrinquedo_DeveRetornarNotFound_QuandoIdNaoExiste()
        {
            // Arrange
            var context = GetDbContext();
            var controller = new BrinquedosController(context);

            // Act
            var result = await controller.GetBrinquedo(999);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task PostBrinquedo_DeveCriarBrinquedo_ERetornarCreatedAtAction()
        {
            // Arrange
            var context = GetDbContext();
            var controller = new BrinquedosController(context);
            var novoBrinquedo = new Brinquedo
            {
                Id_brinquedo = 1,
                Nome_brinquedo = "Lego",
                Tipo_brinquedo = "Montar",
                Classificacao = "+5",
                Tamanho = "Pequeno",
                Preco = 150
            };

            // Act
            var actionResult = await controller.PostBrinquedo(novoBrinquedo);

            // Assert
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(actionResult.Result);
            var brinquedoRetornado = Assert.IsType<Brinquedo>(createdAtActionResult.Value);
            Assert.Equal("Lego", brinquedoRetornado.Nome_brinquedo);
        }

        [Fact]
        public async Task PutBrinquedo_DeveRetornarBadRequest_QuandoIdsNaoBatem()
        {
            // Arrange
            var context = GetDbContext();
            var controller = new BrinquedosController(context);
            var brinquedo = new Brinquedo { Id_brinquedo = 1, Nome_brinquedo = "Carrinho" };

            // Act
            var result = await controller.PutBrinquedo(2, brinquedo);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("O ID da URL não bate com o ID do corpo da requisição.", badRequestResult.Value);
        }

        [Fact]
        public async Task DeleteBrinquedo_DeveRemoverBrinquedo_QuandoIdValido()
        {
            // Arrange
            var context = GetDbContext();
            var brinquedo = new Brinquedo { Id_brinquedo = 1, Nome_brinquedo = "Pião", Tipo_brinquedo = "Tradicional", Classificacao = "Livre", Tamanho = "Pequeno", Preco = 10 };
            context.Brinquedos.Add(brinquedo);
            await context.SaveChangesAsync();
            var controller = new BrinquedosController(context);

            // Act
            var result = await controller.DeleteBrinquedo(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
            Assert.Empty(context.Brinquedos);
        }
    }
}