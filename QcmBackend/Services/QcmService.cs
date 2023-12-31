using QcmBackend.Models;

namespace QcmBackend.Services
{
    public class QcmService : IQcmService
    {
        public QcmService()
        {
            QcmsList = new List<Qcm>
            {
                new Qcm{ Id= 0, Name="Introduction Vanilla JS", NbPoint= 10, Subject="Javascript" },
                new Qcm{ Id= 1, Name="Framework Frontend", NbPoint= 20, Subject="Angular" },
                new Qcm{ Id= 2, Name="IFramework Backend", NbPoint= 20, Subject="Express" },
            };
        }
        public IList<Qcm> QcmsList { get; set; }

        public Qcm CreateQcm(QcmRequest request)
        {
            var newId = QcmsList.Select(x => x.Id).Max() + 1;
            QcmsList.Add(new Qcm
            {
                Id = newId,
                Subject = request.Subject,
                Name = request.Name,
                Author = request.Author,
                NbPoint = request.NbPoint
            });
            return QcmsList.Where(x => x.Id == newId).FirstOrDefault();
        }

        public Qcm GetQcmById(int qcmId)
        {
            return QcmsList.Where(x => x.Id == qcmId).FirstOrDefault();
        }

        public IEnumerable<Qcm> GetQcms()
        {
            return QcmsList;
        }
    }
}