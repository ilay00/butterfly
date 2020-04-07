using UnityEngine;


[CreateAssetMenu(fileName = "ButterflyData", menuName = "CreateModel/Butterfly", order = 0)]
public sealed class ButterflyData : ScriptableObject
{
    #region Fields

    public ButterflyStruct ButterflyStruct;

    #endregion


    #region Metods

    public void Move(Transform transform, Transform target, float speed)
    {
        transform.position = Vector2.MoveTowards
            (transform.position,
            target.transform.position,
            speed);
    }

 /*  public void ChangeButterflyCollider(BoxCollider2D ButterflyCollider2D, float ButterflyRadius)
    {
        if(ButterflyCollider2D != null)
        {
            BoxCollider2D.radius = ButterflyRadius;
        }       
    }*/
    
    #endregion
}
