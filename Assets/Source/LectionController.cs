using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectionController : MonoBehaviour
{
    [SerializeField] private List<int> _list_number;
    [SerializeField] private int _list_value; 
    [SerializeField] private int _list_index;


    [ContextMenu("Print List")]
    private void PrintList()
    {
        Debug.Log($"List: {ParseList(_list_number)}");
    }


    [ContextMenu("Add Value to List")]
    public void AddValueToList()
    {
        _list_number.Add(_list_value);
        Debug.Log($"Added {_list_value} to the list.");
    }


    [ContextMenu("Delete Value from List by Index")]
    public void DeleteValueFromListByIndex()
    {
        if ( _list_index < _list_number.Count)
        {
            int removedValue = _list_number[_list_index];
            _list_number.RemoveAt(_list_index);
            Debug.Log($"Removed value {removedValue} at index {_list_index}.");
        }
        else
        {
            Debug.LogError($"Index {_list_index} is out of range. List size: {_list_number.Count}");
        }
    }


    [ContextMenu("Delete Value from List by Value")]
    public void DeleteValueFromListByValue()
    {
        if (_list_number.Contains(_list_value))
        {
            _list_number.Remove(_list_value);
            Debug.Log($"Removed value {_list_value} from the list.");
        }
        else
        {
            Debug.LogError($"Value {_list_value} not found in the list.");
        }
    }

   
    [ContextMenu("Sort List in Ascending Order")]
    private void SortListAscending()
    {
        _list_number.Sort();
        Debug.Log($"List sorted in ascending order: {ParseList(_list_number)}");
    }


    [ContextMenu("Sort List in Descending Order")]
    private void SortListDescending()
    {
        _list_number.Sort((a, b) => b.CompareTo(a));
        Debug.Log($"List sorted in descending order: {ParseList(_list_number)}");
    }

    private string ParseList(List<int> list)
    {
        return string.Join(",", list);
    }
}
