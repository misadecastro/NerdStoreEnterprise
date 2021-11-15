using NSE.Core.DomainObjects;
using System.Threading.Tasks;

namespace NSE.Pedido.Domain.Voucher
{
    public interface IVoucherRepository : IRepository<Voucher>
    {
        Task<Voucher> ObterVoucherPorCodigo(string codigo);
    }
}
