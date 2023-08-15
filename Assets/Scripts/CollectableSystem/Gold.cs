namespace CollectableSystem
{
    public class Gold : Collectable
    {
        protected override void OnCollected()
        {
            DataManager.Instance.PlayerData.Gold++;
            gameObject.SetActive(false);
        }
    }
}