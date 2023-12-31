using QcmBackend.Models;

namespace QcmBackend.Services
{
    public interface IQcmService
    {
        Qcm CreateQcm(QcmRequest request);
        Qcm GetQcmById(int qcmId);
        IEnumerable<Qcm> GetQcms();
    }
}
