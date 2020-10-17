from datetime import datetime, date, time

# print(date(2020, 1, 20))
t=(2020, 1, 23)
print(date(t[0], t[1], t[2]))
dt=date(t[0], t[1], t[2])
print(dt.weekday())
print(dt.month)
# print(datetime())
# print('{0}/{1}/{2}'.format(dt.day, dt.month, dt.year))

# timestamp = datetime.fromtimestamp(1500000000)
# print(datetime.date(timestamp))

t=(13, 54, 23)
times=time(t[0], t[1], t[2])
print(times)

string='wer12  weqf'
print(string.replace(' ', ''))
print(string)

print(string.split())
print(string)