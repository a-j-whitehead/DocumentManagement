namespace DocumentManagement.Domain.Infrastructure
{
    public interface IS3Client
    {
        public byte[] GetTemplate(Template template);
        public void UploadTemplate(Template template, byte[] fileData);
    }
}
