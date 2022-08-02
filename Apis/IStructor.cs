namespace Worsoon.ESql.Apis;

public interface IStructor<T>
{
    public bool HasTable();
    public bool CreateTable();
    public bool AlterTable();
    public bool SyncTable();
    public bool DropTable();
}