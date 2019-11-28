#assumption is at least one cube will be there on the designated plane of HxB

def surfaceArea(x, H, W):

    fromTopToBottom =2*H*W
    print('fromTopToBottom',fromTopToBottom)
    
    leftSide= sum([ x[0][i] for i in range(W) ])
    print('leftSide', leftSide )
    
    rightSide= sum([ x[H-1][i] for i in range(W) ])
    print('rightSide', rightSide)
    
    lateralTopSide=sum([ x[i][0] for i in range(H)])
    print('lateralTopSide', lateralTopSide)
    
    lateralBottomSide=sum([x[i][W-1] for i in range(H)])
    print('lateralBottomSide', lateralBottomSide)

    leftToRight=0
    rightToLeft=0
    lateralTopToBottom=0
    lateralBottomToTop=0

    for j in range(W-1):
        for i in range(H-1):

            # moving left to right but counting the back side
            if x[i+1][j]-x[i][j] > 0: #and i+1< len(x):
                leftToRight+=x[i+1][j]-x[i][j]

            # moving left to right but counting the front side
            if x[i][j]-x[i+1][j]>0 : #and i+1 < len(x):
                rightToLeft+= x[i][j]-x[i+1][j]

    print('rightToLeft',rightToLeft, 'leftToRight',leftToRight)
    for i in range(H-1):    
        for j in range(W-1):

            # moving lateral top to lateral bottom but counting the back side
            if x[i][j+1]-x[i][j] > 0: #and i+1< len(x):
                lateralTopToBottom+=x[i][j+1]-x[i][j]

            # moving lateral top to lateral bottom but counting the front side
            if x[i][j]-x[i][j+1]>0 : #and i+1 < len(x):
                lateralBottomToTop+= x[i][j]-x[i+1][j+1]

    print('lateralTopToBottom', lateralTopToBottom, 'lateralBottomToTop', lateralBottomToTop)
    return fromTopToBottom+(leftSide+leftToRight+rightToLeft+rightSide) +( lateralTopSide+lateralTopToBottom+lateralBottomToTop+lateralBottomSide)


A =[
    [1, 3, 4],
    [2, 2, 3],
    [1, 2, 4]
    ]
    #30+18+7+5
print('surfaceArea(A, 3, 3)',surfaceArea(A, 3, 3))