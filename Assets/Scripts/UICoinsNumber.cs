using UnityEngine;
using UnityEngine.Events;

public class UICoinsNumber : MonoBehaviour
{
    [SerializeField]
    private int _coins = 0;
    [SerializeField]
    private UnityEvent<int> _onCoinUpdated;
    public void AddCoins(int amount)
    {
        _coins += amount;
        _onCoinUpdated?.Invoke(_coins);
    }
    public void SetCoins(int amount)
    {
        _coins += amount;
        _onCoinUpdated?.Invoke(_coins);
    } 
    public void SubtractCoins(int amount)
    {
        _coins += amount;
        _onCoinUpdated?.Invoke(_coins);
    }



}
