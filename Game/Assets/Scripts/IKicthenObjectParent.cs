using UnityEngine;
public interface IKicthenObjectParent {
    public Transform GetKitchenObjectFollowTransform();

    public void SetKitchenObject(KitchenObject kitchenObject);

    public KitchenObject GetKitchenObject();
    public void ClearKitchenObject();
    public bool HasKitchenObject();
}
