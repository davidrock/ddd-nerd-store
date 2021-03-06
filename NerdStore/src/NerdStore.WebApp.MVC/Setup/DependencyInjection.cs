
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalog.Application.Services;
using NerdStore.Catalog.Data;
using NerdStore.Catalog.Data.Repository;
using NerdStore.Catalog.Domain;
using NerdStore.Core.Bus;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Notifications
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            //// Event Sourcing
            //services.AddSingleton<IEventStoreService, EventStoreService>();
            //services.AddSingleton<IEventSourcingRepository, EventSourcingRepository>();

            // Catalogo
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<CatalogContext>();

            //services.AddScoped<INotificationHandler<ProductAbaixoEstoqueEvent>, ProductEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoIniciadoEvent>, ProductEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoProcessamentoCanceladoEvent>, ProductEventHandler>();

            //// Vendas
            //services.AddScoped<IPedidoRepository, PedidoRepository>();
            //services.AddScoped<IPedidoQueries, PedidoQueries>();
            //services.AddScoped<VendasContext>();

            //services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoverItemPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<AplicarVoucherPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<IniciarPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<FinalizarPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoCommand, bool>, PedidoCommandHandler>();
            //services.AddScoped<IRequestHandler<CancelarProcessamentoPedidoEstornarEstoqueCommand, bool>, PedidoCommandHandler>();

            //services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoEstoqueRejeitadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoPagamentoRealizadoEvent>, PedidoEventHandler>();
            //services.AddScoped<INotificationHandler<PedidoPagamentoRecusadoEvent>, PedidoEventHandler>();

            //// Pagamento
            //services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            //services.AddScoped<IPagamentoService, PagamentoService>();
            //services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            //services.AddScoped<IPayPalGateway, PayPalGateway>();
            //services.AddScoped<IConfigurationManager, ConfigurationManager>();
            //services.AddScoped<PagamentoContext>();

            //services.AddScoped<INotificationHandler<PedidoEstoqueConfirmadoEvent>, PagamentoEventHandler>();
        }
    }
}