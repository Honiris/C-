__license__ = 'Nathalie (c) EPITA'
__docformat__ = 'reStructuredText'
__revision__ = '$Id: heap.py 2018-02-13'

"""
Heap homework
2018
@author: mathias.deroche
"""

#given function

def newHeap():
    """ returns a fresh new empty heap
       :rtype: list (heap)
    """
    return [None]

#---------------------------------------------------------------

def isEmpty(H):
    """ tests if H is empty
    
       :param H: the heap
       :rtype: bool
    """
    return len(H) == 1

def heapPush(H, elt, val):
    """ adds the pair (val, elt) to heap H and returns the heap modified
    
       :param H: The heap
       :param elt: The element to add
       :param val: The value associated to elt
       :rtype: list  (heap)
    """
    if isEmpty(H):
        H.append((elt, val))
        return H
    else:
        m = len(H)
        i = 0
        while (elt, val) > H[i]:
            i += 1
        i -= 1
        l = []
        for i in range(i + 1, len(H)):
            l.append(H[i])
        for i in range(1, len(H)):
            H.pop()

def heapPop(H):
    """ returns and deletes the element of smallest value
    
       :param H: The heap
       :rtype: any (the removed element)
    
    """
    if isEmpty(H):
        return None
    else:
        m = len(H)
        tup = H[1]
        if len(H) == 2:
            H.pop()
            return tup
        else:
            l = []
            for i in range(2, m):
                l.append(H[i])
            for i in range(1, m):
                H.pop()
            for i in range(m - 3, 1, -1):
                H.append(l[i]) 
            return tup

#---------------------------------------------------------------
def isHeap(T):
    """ tests whether T is a heap
    
       :param T: list (a complete tree)
       :rtype: bool
    
    """
    if T is None:
        return True
    elif T.left is T.right:
        return True
    elif T.left is None and T.right is not None:
        return T.key <= T.right.key and isHeap(T.right)
    elif T.left is not None and T.right is None:
        return T.key <= T.left.key and isHeap(T.left)
    else:
        l = T.left.key
        r = T.right.key
        t = T.key
        return t <= l and t <= r and isHeap(T.left) and isHeap(T.right)

def heapify(H):
    """ makes H a heap (in place) - returns H modified
    
      :param H: list (a complete tree)
      :rtype: list (a heap)
    """    

    #FIXME
