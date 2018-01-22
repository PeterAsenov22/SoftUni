function lastMonth([day,month,year]) {
    let date = new Date(year,month-1);
    date.setDate(0);

    console.log(date.getDate());
}
