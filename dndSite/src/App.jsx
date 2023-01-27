import "./App.css";

function App() {
  let headerInputsLabelENG = [
    {
      className: "classNLvLInput",
      label: "Class & LvL",
      inputType: "text",
    },
    {
      className: "",
      label: "Background",
      inputType: "text",
    },
    {
      className: "",
      label: "Player Name",
      inputType: "text",
    },
    {
      className: "",
      label: "Race",
      inputType: "text",
    },
    {
      className: "",
      label: "Alignment",
      inputType: "text",
    },
    {
      className: "",
      label: "Experience Points",
      inputType: "number",
    },
  ];

  let basicCharacteristicsENG = [
    "Strength",
    "Dexterity",
    "Constitution",
    "Intelligence",
    "Wisdom",
    "Charisma",
  ];

  let secondAbilitiesENG = [
    {
      name: "Acrobatics",
      abilityDetail: "Dex",
    },
    {
      name: "Animal Handling",
      abilityDetail: "Wis",
    },
    {
      name: "Arcana",
      abilityDetail: "Int",
    },
    {
      name: "Athletics",
      abilityDetail: "Str",
    },
    {
      name: "Deception",
      abilityDetail: "Cha",
    },
    {
      name: "History",
      abilityDetail: "Int",
    },
    {
      name: "Insight",
      abilityDetail: "Wis",
    },
    {
      name: "Intimidation",
      abilityDetail: "Cha",
    },
    {
      name: "Investigation",
      abilityDetail: "Int",
    },
    {
      name: "Medicine",
      abilityDetail: "Perception",
    },
    {
      name: "Nature",
      abilityDetail: "Int",
    },
    {
      name: "Perception",
      abilityDetail: "Wis",
    },
    {
      name: "Performance",
      abilityDetail: "Cha",
    },
    {
      name: "Persuasion",
      abilityDetail: "Cha",
    },
    {
      name: "Religion",
      abilityDetail: "Int",
    },
    {
      name: "Sleight of Hand",
      abilityDetail: "Dex",
    },
    {
      name: "Stealth",
      abilityDetail: "Dex",
    },
    {
      name: "Survival",
      abilityDetail: "Wis",
    },
  ];

  return (
    <div className="App displayGrid">
      <div id="firstPage">
        <div id="generalInfor" className="displayFlex">
          <div id="charNameDiv" className="displayFlex">
            <input
              type="text"
              placeholder="Character name"
              id="charNameInput"
            />
            <br />
            <label htmlFor="charNameInput">Character name</label>
          </div>
          <div id="generalInfoInput" className="displayGrid">
            {headerInputsLabelENG.map((headerInput) => {
              return (
                <div key={headerInput.label}>
                  <input
                    type={headerInput.inputType}
                    placeholder={headerInput.label}
                    id={headerInput.className}
                  />
                  <label htmlFor={headerInput.className}>
                    {headerInput.label}
                  </label>
                </div>
              );
            })}
          </div>
        </div>

        <div id="column1">
          <div id="sideSpecs">
            {basicCharacteristicsENG.map((characteristic) => {
              return (
                <div key={characteristic}>
                  <div>{characteristic}</div>
                  <div>
                    <input type="number" />
                  </div>
                  <div>
                    <input type="number" />
                  </div>
                </div>
              );
            })}
          </div>
          <div id="leftColumn1">
            <div id="leftSide1">
              <input type="number" name="" id="inspirationInput" />
              <label htmlFor="inspirationInput">Inspiration</label>
            </div>
            <div id="leftSide2">
              <input type="number" name="" id="proficiencyInput" />
              <label htmlFor="proficiencyInput">Proficiency Bonus</label>
            </div>
            <div id="leftSide3">
              {basicCharacteristicsENG.map((characteristic) => {
                return (
                  <div key={characteristic}>
                    <input type="checkbox" name="" id="" />
                    <input type="number" name="" id="" />
                    <label htmlFor="">{characteristic}</label>
                  </div>
                );
              })}
            </div>
            <div id="leftSide4"></div>
            {secondAbilitiesENG.map((ability) => {
              return (
                <div key={ability.name}>
                  <input type="checkbox" name="" id="" />
                  <input type="number" name="" id="" />
                  <label htmlFor="">
                    {ability.name + "(" + ability.abilityDetail + ")"}
                  </label>
                </div>
              );
            })}
          </div>
        </div>
        <div id="column2"></div>
        <div id="column3"></div>
      </div>
    </div>
  );
}

export default App;
