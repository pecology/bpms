window.onload = () => {
  document.querySelector("#year-select").onchange = jumpToSelectedMonthList;
  document.querySelector("#month-select").onchange = jumpToSelectedMonthList;
}

const jumpToSelectedMonthList = () => {
  const year = document.querySelector("#year-select").value;
  const month = document.querySelector("#month-select").value;
  const url = location.pathname + `?year=${year}&month=${month}`;
  jump(url);
}

const jump = url => {
  const anchor = document.createElement("a");
  anchor.href = url;
  anchor.click();
}