def find_rank(lb, x):
    l=0
    r=len(lb)-1
    
    while l<=r:
        mid=(l+r)//2
        if x>=lb[mid] and lb[mid-1]>x and mid-1>=0:
            return mid+1
        else:
            # 100, 90, 80, 75, 60
            # 50
                        
            if(x>=lb[mid-1]):
                r=mid
            if x<lb[mid]:
                l=mid+1
    else:
        return -1



# get dense rank of leaderboard
def denseRank(scores):
    p=[]
    for i in scores:
        if p==[] or i not in p:
            p.append(i)
    return p
# Complete the climbingLeaderboard function below.
def climbingLeaderboard(scores , alice):
    denseLB=denseRank(scores)
    alice_rank=[]
    for i in alice:
        
        if i >=denseLB[0]:
            alice_rank.append(1)
        elif i < denseLB[len(denseLB)-1]:
            alice_rank.append(len(denseLB)+1)
        else:
            #since all the arrays are sorted we can use binary search to find our required items
            alice_rank.append( find_rank(denseLB, i))
    return alice_rank
print( 'climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102])',climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102]))
# print( climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102]))
# print('climbingLeaderboard( ([100, 90 ,90, 80, 75, 60],[50 ,65, 77, 90, 102])', climbingLeaderboard( [100, 90 ,90, 80, 75, 60],[50 ,65, 77, 90, 102]))